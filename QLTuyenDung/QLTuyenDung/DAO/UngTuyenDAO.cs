﻿using QLTuyenDung.Models;

namespace QLTuyenDung.DAO
{
    public class UngTuyenDAO
    {
        DataContext _dataContext;
        public UngTuyenDAO(DataContext dataContext)
        {
            _dataContext = dataContext;
        } 
        
        public async Task<DonUngTuyen> UngTuyen(DonUngTuyen donUT)
        {
            var don = await _dataContext.DSDonUT.AddAsync(donUT);
            _dataContext.SaveChanges();
            return don.Entity;
        }
            
        
    }
}
