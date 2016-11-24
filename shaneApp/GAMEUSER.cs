namespace shaneApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.GAMEUSER")]
    public partial class GAMEUSER

    {

        private byte userId;
        private string userEmail;
        private string userPassword;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GAMEUSER()
        {
            PLAYERs = new HashSet<PLAYER>();
        }

        [Key]
        public byte USERID {
            get { return userId; }
            set { this.userId = userId;}
            }

        [StringLength(20)]
        public string USEREMAIL { get {return userEmail; }
                                  set {this.userEmail = userEmail;  }}

        [StringLength(20)]
        public string USERPASSWORD { get {return userPassword;}
                                     set { this.userPassword = userPassword; } }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLAYER> PLAYERs { get; set; }
    }
}
