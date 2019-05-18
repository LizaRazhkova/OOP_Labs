namespace OOPLAST9
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USERS_INFO
    {
        public int? UserID { get; set; }

        [Key]
        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserSurname { get; set; }

        public int? UserBalanceID { get; set; }

        public int? UserIdHistoryTrans { get; set; }

        public virtual USERS_LOG USERS_LOG { get; set; }
    }
}
