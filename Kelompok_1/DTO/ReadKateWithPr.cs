﻿namespace Kelompok_1.DTO
{
    public class ReadKateWithPr
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public List<ProdukReadDTO> Produks { get; set; } = new List<ProdukReadDTO>();
    }
}
