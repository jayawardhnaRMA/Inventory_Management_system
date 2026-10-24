using System.ComponentModel;

namespace ShopManagementSystem.Models
{
    // Abstract base for everything stored in the database. Every entity has an ID
    // and must know how to validate itself before it is saved.
    public abstract class Entity
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [Browsable(false)]
        public bool IsNew => Id == 0;

        public abstract void Validate();
    }
}
