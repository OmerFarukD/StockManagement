using StockManagement.ConsoleUI.Service;

// See https://aka.ms/new-console-template for more information
// Bir ürünler listesi oluşturunuz.
// Bir Kategoriler listesi oluşturunuz.

// Bütün ürünleri listeleyen kodu yazınız.
// Bütün kategorileri listeleyen kodu yazınız.

// kullanıcıdan Kategori verilerini alıp listeye ekleyen 
// Kural olarak daha önce kullanıcının girmiş olduğu Id değerine ait veri varsa
// Ekran çıktısı olarak Id alanı benzersiz olmalıdır :{Id}
// listeyi ekran çıktısı olarak isteyen kodu yazınız.

// Ürünlerin fiyat toplamını gösteren kodu yazınız.

// kullanıcıdan iki değer alalım bu değerler min ve max değerleri olsun(Price)
// bu 2 değer arasında stok verilerini getirsin.

// ürünler listesinde bir isim parametresi alarak ürün isimlerinden uyuşanları listelesin

// Kullanıcı bir Id girdiği zaman o id ye göre kitabı silen ve yeni listeyi ekrana bastıran
// kodu yazınız.


// Kullanıcıdan ilk başta id değeri alıp arama yaptıktan sonra eğer o Id ye ait
// bir kitap yoksa "İlgili Id ye ait bir kitap bulunamadı."
//* Güncellenecek olan değerler kullanıcıdan alınacak.


// Kullanıcıdan id ve Stok değerlerini alınız.
// Ürün kaç adet isteniyorsa o kadar satılsın eğer stokta varsa
// Kullanıcı ürün aldıktan sonra stok miktarı 0 a düşüyorsa ürün silinsin

// Kullanıcının almak isteiği ürün 50 ama stok ta 40 tane var 
// Alabileceğiniz max miktar : 40

// Stokdan düşüş yapılsın

// Hanfi ürünü aldıysa ürünün adı ve kaç adet aldığı ve toplam ücreti gösteriniz.



// Prime Örnekler:
// Pagination Desteği getirelecek:


//ProductDetail(ProductName, ProductPrice, ProductStock,strin CategoryName);
// kullanarak ürün detaylarının listesini ekrana yazınız.



//GetAllProducts();
//GetAllCategories();
//AddProductAndGetAll();
//TotalProductPriceSum();

//GetAllPriceRange(10000,50000);
//GetAllProductsByPriceFiltered();

//GetAllProductNameContains();

//DeleteProduct();

//StockUpdate();

//AddProduct();


ProductService productService = new ProductService();
productService.GetDetailById(new Guid("{3BED90AE-FA0A-4ECE-959B-3A5D804E4471}"));



//void StockUpdate()
//{
//    GetAllProducts();
//    PrintAyirac("Güncellemek istediğiniz veriyi yazınız:");

//    Console.WriteLine("Lütfen id değerini giriniz: ");
//    int id = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Lütfen stok değerini giriniz: ");
//    int stock = Convert.ToInt32(Console.ReadLine());


//    Product product= new Product(0,string.Empty,0,0);

//    foreach (Product p in products)
//    {
//        if (p.Id==id)
//        {
//            product = p;
//            break;
//        }
//    }

//    if (stock > product.Stock)
//    {
//        Console.WriteLine($"Bu üründen max : {product.Stock} kadar almanız gerekmektedir.");
//        return;
//    }


//    int newStock = product.Stock-stock;
//    Product updatedProduct = new Product(
//        product.Id,
//        product.Name,
//        product.Price,
//        newStock
//        );

//    if(updatedProduct.Stock == 0)
//    {
//        products.Remove(product);
//        Console.WriteLine("Bütün Ürünleri aldınız.");
//        GetAllProducts();
//        return;
//    }



//    string productName = updatedProduct.Name;
//    int adetSayisi = stock;

//    double totalPrice = stock * updatedProduct.Price;

//    Console.WriteLine($"Ürün Adı : {productName}");
//    Console.WriteLine($"Adet Sayısı : {adetSayisi}");
//    Console.WriteLine($"Toplam ücret : {totalPrice}");

//    int productIndex = products.IndexOf(product);

//      products.Remove(product);
//      products.Insert(productIndex,updatedProduct);
//    GetAllProducts();


//}




//void GetAllProducts()
//{
//    PrintAyirac("Bütün Ürünler");
//    foreach (Product product in products)
//    {
//        Console.WriteLine(product);
//    }
//}


//void PrintAyirac(string title)
//{
//    Console.WriteLine(title);
//    Console.WriteLine("--------------------------------------------");
//}

//// Ürün adı benzersiz olsun 
//// Stok ve Price Alanları 0 dan büyük olmak zorundadır

//bool AddProductValidator(Product product)
//{

//    foreach (Product item in products)
//    {
//        if (item.Id == product.Id)
//        {

//            GetNotUniqueMessage("Id");
//            return false;
//        }

//        if (item.Name == product.Name)
//        {
//            GetNotUniqueMessage("Name");
//            return false;
//        }


//    }



//    if (product.Stock <= 0)
//    {
//        Console.WriteLine("Eklemek istediğiniz Ürünün stok değeri negatif olamaz");
//        return false;
//    }

//    if (product.Price <= 0)
//    {
//        Console.WriteLine("Eklemek istediğiniz Ürünün Fiyat değeri negatif olamaz");
//        return false;
//    }


//    return true;
//}

//void GetNotUniqueMessage(string property)
//{
//    Console.WriteLine($"Eklemek istediğiniz ürünün alanı Benzersiz olmalıdır. : {property}");

//}

//void GetProductAddedInput(out int id,out string name, out double price,out int stock)
//{
//    Console.WriteLine("Lütfen Ürün Id sini giriniz: ");
//    id = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Lütfen Ürün adını giriniz: ");
//     name = Console.ReadLine();

//    Console.WriteLine("Lütfen Ürün Değerini giriniz: ");
//     price = Convert.ToInt32(Console.ReadLine());


//    Console.WriteLine("Lütfen Stok adedini giriniz: ");
//     stock = Convert.ToInt32(Console.ReadLine());

//}

//Product GetAddedProductInputV2()
//{
//    Console.WriteLine("Lütfen Ürün Id sini giriniz: ");
//   int id = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Lütfen Ürün adını giriniz: ");
//   string name = Console.ReadLine();

//    Console.WriteLine("Lütfen Ürün Değerini giriniz: ");
//   int price = Convert.ToInt32(Console.ReadLine());


//    Console.WriteLine("Lütfen Stok adedini giriniz: ");
//    int stock = Convert.ToInt32(Console.ReadLine());

//    Product product = new Product(id, name, price, stock);

//    return product;
//}



//void GetPriceRangeData(out double min, out double max)
//{
//    Console.WriteLine("Lütfen minimum değeri giriniz: ");
//     min = Convert.ToDouble(Console.ReadLine());

//    Console.WriteLine("Lütfen Max değeri giriniz: ");
//    max = Convert.ToDouble(Console.ReadLine());
//}

//void GetAllProductsByPriceFiltered()
//{
//    double min;
//    double max;
//    GetPriceRangeData(out min, out max);
//    GetAllPriceRange(min,max);
//}



//string GetProductNameData()
//{
//    Console.WriteLine("Lütfen aramak istediğiniz ürünü yazınız: ");
//    string text = Console.ReadLine();
//    return text;
//}




