//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterPolIlyasov
{
    using System;
    using System.Collections.Generic;
    
    public partial class Suplly
    {
        public int SupllyID { get; set; }
        public int Supllier { get; set; }
        public int Master { get; set; }
        public System.DateTime SupllyDate { get; set; }
        public decimal QuantitySupplied { get; set; }
        public int Material { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Material Material1 { get; set; }
        public virtual Supllier Supllier1 { get; set; }
    }
}
