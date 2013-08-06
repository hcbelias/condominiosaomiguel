using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Data.Objects;
using System.Data.Common;
using System.Data.SqlClient;

namespace DAL
{
    public class DataContext : DataModelContainer
    {
        private static readonly Dictionary<Thread, DataContext> m_Context = new Dictionary<Thread, DataContext>();
        private System.Transactions.TransactionOptions m_TransactionOptions;
        private System.Transactions.TransactionScope m_TransactionScope;
        private String authenticatedUser;

        public DataContext() { }

        public String AuthenticatedUser
        {
            get { return authenticatedUser; }
            set { authenticatedUser = value; }
        }

        public DataContext(string userAuthenticated)
            : base()
        {
            m_TransactionOptions = new System.Transactions.TransactionOptions();
            this.ContextOptions.LazyLoadingEnabled = true;
            m_TransactionOptions.IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted;
            m_TransactionScope = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, m_TransactionOptions);
            this.AuthenticatedUser = userAuthenticated;
        }

        public static DataContext CreateContext(string userAuthenticated)
        {
            lock (m_Context)
            {
                m_Context[Thread.CurrentThread] = new DataContext(userAuthenticated);
                return (DataContext)m_Context[Thread.CurrentThread];
            }
        }

        public static DataContext GetContext()
        {
            lock (m_Context)
            {
                if (!m_Context.ContainsKey(Thread.CurrentThread))
                    return null;
                return (DataContext)m_Context[Thread.CurrentThread];
            }
        }

        public static void ReleaseContext()
        {
            lock (m_Context)
            {
                DataContext v_Context = GetContext();
                if (v_Context != null)
                {
                    GetContext().m_TransactionScope.Complete();
                    GetContext().m_TransactionScope.Dispose();
                    GetContext().Dispose();
                    m_Context[Thread.CurrentThread] = null;
                }
            }
        }

        public static void CommitContext()
        {
            lock (m_Context)
            {
                ((DataContext)m_Context[Thread.CurrentThread]).SaveChanges();
            }
        }


    }
}
