﻿namespace API.Data.VO
{
    public class ClientVO
    {
        public int Id {  get; set; }
        public string Name { get; set; } = string.Empty;
        public string CellNumber { get; set; } = string.Empty;
        public string CellNumberAlternative { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<AddressVO> Addresses { get; set; } = new List<AddressVO>();
        public List<ServiceOrderVO> ServiceOrders { get; set; } = new List<ServiceOrderVO>();
    }
}
