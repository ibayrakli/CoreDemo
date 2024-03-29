﻿using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface ICategoryService
	{
		void CategoryAdd(Category category);
        void CategoryUpdate(Category category);
        void CategoryDelete(Category category);

        List<Category> GetList();

        Category GetById(int id);
    }
}

