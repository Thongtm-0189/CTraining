﻿
internal class Program
{
    private static void Main(string[] args)
    {
        //MyStoreContext context = new MyStoreContext();

        // Selection all
        //List<Product> products = context.Products.ToList();
        //List<Category> categories = context.Categories.ToList();

        //products.ForEach(p => Console.WriteLine(p.Category.Name));
        //foreach (var item in categories[0].Products)
        //{
        //    Console.WriteLine(item.Name);
        //}

        // Craete
        // Bởi vì product đang có quan hệ với category và khoá ngoại là categoriId
        // Lúc này insert nó kh thấy có add khoá ngoại nhưng
        // Có add category của mối quan hệ, nên Dbcontext tự động hiểu 
        // CategoryId (khoá ngoại) = id với id của Category mới vừa tạo
        //Product product = new Product
        //{
        //    Name = "test 5",
        //    Category = new Category
        //    {
        //        Name = "test cate 5",
        //        Age = "5"
        //    }
        //};
        //context.Products.Add(product);
        //context.SaveChanges();

        // read
        // select many
        //List<Product> products = context.Products.Where(p => p.Id > 2).ToList();
        // select single
        //Product product = context.Products.FirstOrDefault(p => p.Id > 2);
        // select with condition include
        //Product product1 = context.Categories.FirstOrDefault(p => p.Id > 2);

        // update
        //Product product = context.Products.FirstOrDefault(p => p.Id == 2);
        //product.Name = "test update";
        //context.Products.Update(product);
        //context.SaveChanges();

        // delete
        //Product product = context.Products.FirstOrDefault(p => p.Id == 2);
        //context.Products.Remove(product);
        //context.SaveChanges();
    }
}