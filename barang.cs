using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prak8
{
    public class barang
    {
        public string nama_barang { get; set; }
        
        public int harga { get; set; }


        public barang()
        {
            this.nama_barang = "[belum diatur]";
     
            this.harga = 0;
        }

        public barang(string nama_barang, int harga)
        {
            this.nama_barang=nama_barang;
            this.harga = 50000;
        }
        public void InfoBarang()
        {
            Console.WriteLine("Nama produk {0}, dan harganya Rp. {1}\n", nama_barang, harga);
        }

        public class dataBrg : barang
        {
            public string IDbarang { get; set; }
            public string jenis { get; set; }
            public dataBrg()
            {
                nama_barang = "[belum diatur]";
                harga = 0;
            }
            public dataBrg(string Nama_baramg, int harga)
            {
                this.nama_barang = nama_barang;
                this.harga = harga;
            }

            public void InfoBarang(string IDbarang, string jenis)
            {
                this.nama_barang = nama_barang;
                this.IDbarang = IDbarang;
                this.jenis = jenis;

                Console.WriteLine("{0} adalah produk berjenis {1}, dengan ID barang {2}",this.nama_barang, this.IDbarang, this.jenis);
            }
        }

    }
}
