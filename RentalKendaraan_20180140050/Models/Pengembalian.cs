using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140050.Models
{
    public partial class Pengembalian
    {
        [Required(ErrorMessage = "Id Pengembalian tidak boleh kosong")]
        public int IdPengembalian { get; set; }

        [Required(ErrorMessage = "Tanggal tidak boleh kosong")]
        public DateTime? TglPengembalian { get; set; }

        [Required(ErrorMessage = "ID Peminjaman tidak boleh kosong")]
        public int? IdPeminjaman { get; set; }

        [Required(ErrorMessage = "ID Kondisi tidak boleh kosong")]
        public int? IdKondisi { get; set; }

        [Required(ErrorMessage = "Denda tidak boleh kosong")]
        public int? Denda { get; set; }

        public KondisiKendaraan IdKondisiNavigation { get; set; }
        public Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
