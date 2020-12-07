using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140050.Models
{
    public partial class KondisiKendaraan
    {
        public KondisiKendaraan()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        [Required(ErrorMessage = "ID Kondisi tidak boleh kosong")]
        public int IdKondisi { get; set; }

        [Required(ErrorMessage = "Kondisi tidak boleh kosong")]
        public string NamaKondisi { get; set; }

        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
