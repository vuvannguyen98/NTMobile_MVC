using System;
using System.Collections.Generic;
using System.Text;

namespace WebNTMobileApp.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Call save change from db context
        /// </summary>
        void Commit();
    }
}
