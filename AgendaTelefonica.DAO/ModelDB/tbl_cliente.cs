//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgendaTelefonica.DAO.ModelDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_cliente()
        {
            this.tbl_cliente_telefone = new HashSet<tbl_cliente_telefone>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public System.DateTime DataNascimento { get; set; }
        public System.DateTime DataCadastro { get; set; }
        public System.DateTime DataAlteracao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_cliente_telefone> tbl_cliente_telefone { get; set; }
    }
}
