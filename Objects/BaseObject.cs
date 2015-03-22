using System;

namespace Servant.Shared.Objects
{
    public abstract class BaseObject
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        protected BaseObject()
        {
            CreatedDate = DateTime.Now;
        }
    }
}