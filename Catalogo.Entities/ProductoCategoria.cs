namespace Catalogo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductoCategoria")]
    public partial class ProductoCategoria
    {
        [Key]
        public long IdProductoCategoria { get; set; }

        public long? IdProducto { get; set; }

        public int? IdCategoria { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
