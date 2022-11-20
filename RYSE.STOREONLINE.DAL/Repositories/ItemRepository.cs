﻿using Microsoft.Extensions.Logging;
using RYSE.STOREONLINE.DAL.Context;
using RYSE.STOREONLINE.DAL.Interfaces;
using System.Linq;
using Item = RYSE.STOREONLINE.DAL.Entities.Item;


namespace RYSE.STOREONLINE.DAL.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly StoreContext context;
        private readonly ILogger<ItemRepository> logger;

        public ItemRepository(StoreContext context,ILogger<ItemRepository> logger) {
            this.context = context;
            this.logger = logger;
        }

        public bool Exists(int itemID)
        {
            return context.Items.Any(cd => cd.Id == itemID);
        }

        public IEnumerable<Item> GetAll()
        {
            
            return context.Items;   
        }

        public Item GetItems(int itemID)
        {
           return context.Items.Find(itemID);  
        }

        public void Remove(Entities.Item item)
        {
            try
            {
            context.Items.Remove(item);

            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }

        public void Save(Entities.Item item)
        {
            try
            {
            context.Items.Add(item);

            }
            catch (Exception e)
            {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }

        public void Update(Entities.Item item)
        {
            try { 
            context.Items.Update(item);
            }catch(Exception e) {
                this.logger.LogError($"Erros: {e.Message}", e.ToString());
            }
        }
    }
}