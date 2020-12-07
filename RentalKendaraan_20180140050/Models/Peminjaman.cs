using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140050.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        [DisplayName("ID")]
        [Required(ErrorMessage = "ID Peminjaman tidak boleh kosong")]
        public int IdPeminjaman { get; set; }

        [DisplayName("Tanggal Peminjaman")]
        [Required(ErrorMessage = "Tanggal tidak boleh kosong")]
        public DateTime? TglPeminjaman { get; set; }

        [DisplayName("Kendaraan")]
        [Required(ErrorMessage = "ID Kendaraan tidak boleh kosong")]
        public int? IdKendaraan { get; set; }

        [DisplayName("Customer")]
        [Required(ErrorMessage = "ID Customer tidak boleh kosong")]
        public int? IdCostumer { get; set; }

        [DisplayName("Jaminan")]
        [Required(ErrorMessage = "ID Jaminan tidak boleh kosong")]
        public int? IdJaminan { get; set; }

        [Required(ErrorMessage = "Biaya tidak boleh kosong")]
        public int? Biaya { get; set; }

        [DisplayName("Customer")]
        public Customer IdCostumerNavigation { get; set; }

        [DisplayName("Jaminan")]
        public Jaminan IdJaminanNavigation { get; set; }

        [DisplayName("Kendaraan")]
        public Kendaraan IdKendaraanNavigation { get; set; }

        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}