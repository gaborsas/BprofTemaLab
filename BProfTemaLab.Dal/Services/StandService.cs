using BProfTemaLab.Dal.Dtos;
using BProfTemaLab.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BProfTemaLab.Dal.Services
{
    public class StandService
    {
        public StandService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public ApplicationDbContext DbContext { get; }

        public static Expression<Func<Stand, StandDto>> StandDtoSelector { get; } = s => new StandDto
        {
            Id = s.Id,
            ProductId = s.ProductId,
            Purchased = s.Purchased,
            ClosingQuantity = s.ClosingQuantity,
            Scrap = s.Scrap,
            Sold = s.Sold,
            Loss = s.Loss,
            Income = s.Income,
            ProductName = s.Product.Name,
            StartingQuantity = s.Product.Quantity,
            UnitPrice = s.Product.UnitPrice
    };

        public IEnumerable<StandDto> GetStands() => DbContext.Stand
            .Select(StandDtoSelector)
            .ToList();

        public StandDto GetStandById(int standId) => DbContext.Stand
            .Where(s => s.Id == standId)
            .Select(StandDtoSelector)
            .Single();

        public void AddStand(Stand stand)
        {
            DbContext.Stand.Add(new Stand
            {
                Id = stand.Id,
                ProductId = stand.ProductId,
                Purchased = stand.Purchased,
                ClosingQuantity = stand.ClosingQuantity,
                Scrap = stand.Scrap,
                Sold = stand.Sold,
                Loss = stand.Loss,
                Income = stand.Income

            });

            DbContext.SaveChanges();
        }

        public void DeleteStand(int standId)
        {
            DbContext.Remove(new Stand { Id = standId });
            DbContext.SaveChanges();
        }
    }
}
