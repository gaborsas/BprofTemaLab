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
            StartingQuantity = s.StartingQuantity,
            Purchased = s.Purchased,
            Sold = s.Sold,
            Scrap = s.Scrap,
            ClosingQuantity = s.ClosingQuantity,
            Loss = s.Loss,
            Income = s.Income,
            ProductName = s.Product.Name,
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
                StartingQuantity = stand.StartingQuantity,
                Purchased = stand.Purchased,
                Sold = stand.Sold,
                Scrap = stand.Scrap,
                ClosingQuantity = stand.ClosingQuantity,
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
