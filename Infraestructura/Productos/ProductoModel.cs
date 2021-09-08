﻿using Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Productos
{
    public class ProductoModel
    {
        private Product[] productos;

        #region CRUD
        public void Add(Product p)
        {
            Add(p, ref productos);
        }

        public Product[] GetAll()
        {
            return productos;
        }

        public int Update(Product p)
        {
            if (p == null)
            {
                throw new ArgumentException("El objeto o producto no puede ser null");
            }

            int index = GetIndexById(p.Id);
            if (index < 0)
            {
                throw new ArgumentException($"El producto con Id {p.Id} no se encuentra");
            }

            productos[index] = p;
            return index;
        }

        public bool Delete(Product p)
        {
            if (p == null)
            {
                throw new ArgumentException("El objeto o producto no puede ser null");
            }

            int index = GetIndexById(p.Id);
            if (index < 0)
            {
                throw new ArgumentException($"El producto con Id {p.Id} no se encuentra");
            }

            if (index != productos.Length - 1)
            {
                productos[index] = productos[productos.Length - 1];
            }

            Product[] tmp = new Product[productos.Length - 1];
            Array.Copy(productos, tmp, tmp.Length);
            productos = tmp;

            return productos.Length == tmp.Length;
        }
        #endregion

        #region Queries
        public Product GetProductByIndex(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException($"El id {id}no e valido");
            }

            int index = GetIndexById(id);

            return index <= 0 ? null : productos[index];
        }
        #endregion

        #region PriveteMethod
        private void Add(Product p, ref Product[] pds)
        {
            if (pds == null)
            {
                pds = new Product[1];
                pds[pds.Length - 1] = p;
                return;
            }

            Product[] tmp = new Product[pds.Length * 1];
            Array.Copy(pds, tmp, pds.Length);
            tmp[tmp.Length - 1] = p;
            pds = tmp;
        }

        private int GetIndexById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El id no puede ser negativo o 0");
            }

            int index = int.MinValue, i = 0;
            if (productos == null)
            {
                return index;
            }

            foreach(Product p in productos)
            {
                if(p.Id == id)
                {
                    index = i;
                    break;
                }
                i++;
            }

            return index;
        }
        #endregion
    }
}