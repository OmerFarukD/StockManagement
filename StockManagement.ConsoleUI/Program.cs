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



using StockManagement.ConsoleUI;

List<Product> products = new List<Product>()
{
    new Product(1,"Beymen Takım Elbise",15000,250),
    new Product(2,"Prada Çanta",60000,10),
    new Product(3,"Hk Vision Drone",400000,25),
    new Product(4,"Dyson Süpürge",32000,200),
    new Product(5,"Karaca Vazo",500,1000),
    new Product(6,"Kütahya Porselen Ayna",1500,200),
    new Product(7, "Adidas Futbol Topu",5000,1254),
    new Product(8,"Delta Yoga Matı",2000,531)
};
List<Category> categories = new List<Category>()
{
    new Category(1,"Elbise","Elbise Açıklaması"),
    new Category(2,"Elektronik","Elektronik Açıklama"),
    new Category(3,"Dekorasyon","Dekorasyon Açıklama"),
    new Category(4,"Spor Aletleri","Spor Aletleri Açıklama"),

};

//GetAllProducts();
//GetAllCategories();
//AddProductAndGetAll();
//TotalProductPriceSum();

//GetAllPriceRange(10000,50000);
//GetAllProductsByPriceFiltered();

//GetAllProductNameContains();

//DeleteProduct();

StockUpdate();



void StockUpdate()
{
    GetAllProducts();
    PrintAyirac("Güncellemek istediğiniz veriyi yazınız:");

    Console.WriteLine("Lütfen id değerini giriniz: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen stok değerini giriniz: ");
    int stock = Convert.ToInt32(Console.ReadLine());


    Product product= new Product(0,string.Empty,0,0);

    foreach (Product p in products)
    {
        if (p.Id==id)
        {
            product = p;
            break;
        }
    }

    if (stock > product.Stock)
    {
        Console.WriteLine($"Bu üründen max : {product.Stock} kadar almanız gerekmektedir.");
        return;
    }


    int newStock = product.Stock-stock;
    Product updatedProduct = new Product(
        product.Id,
        product.Name,
        product.Price,
        newStock
        );

    if(updatedProduct.Stock == 0)
    {
        products.Remove(product);
        Console.WriteLine("Bütün Ürünleri aldınız.");
        GetAllProducts();
        return;
    }



    string productName = updatedProduct.Name;
    int adetSayisi = stock;

    double totalPrice = stock * updatedProduct.Price;

    Console.WriteLine($"Ürün Adı : {productName}");
    Console.WriteLine($"Adet Sayısı : {adetSayisi}");
    Console.WriteLine($"Toplam ücret : {totalPrice}");

    int productIndex = products.IndexOf(product);

      products.Remove(product);
      products.Insert(productIndex,updatedProduct);
    GetAllProducts();


}


void GetAllCategories()
{
    PrintAyirac("Bütün Kategoriler");
    foreach (Category category in categories)
    {
        Console.WriteLine(category);
    }
}

void GetAllProducts()
{
    PrintAyirac("Bütün Ürünler");
    foreach (Product product in products)
    {
        Console.WriteLine(product);
    }
}


void PrintAyirac(string title)
{
    Console.WriteLine(title);
    Console.WriteLine("--------------------------------------------");
}


void AddProductAndGetAll()
{
    bool isUnique = true;

    PrintAyirac("Ürün ekle ve listele");

    Console.WriteLine("Lütfen Ürün Id sini giriniz: ");
    int id = Convert.ToInt32(Console.ReadLine());

    foreach(Product product in products)
    {
        if(product.Id == id)
        {
            isUnique = false;
            break;
        }
    }

    if (!isUnique)
    {
        Console.WriteLine($"Id alanı benzersiz olmalıdır : {id}");
        return;
    }

    Console.WriteLine("Lütfen Ürün adını giriniz: ");
    string name = Console.ReadLine();

    Console.WriteLine("Lütfen Ürün Değerini giriniz: ");
    double price = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Lütfen Stok adedini giriniz: ");
    int stock = Convert.ToInt32(Console.ReadLine());

    Product createdProduct = new Product(id,name,price,stock);
    products.Add(createdProduct);


    foreach (Product product in products) 
    {
        Console.WriteLine(product);
    }
}


void TotalProductPriceSum()
{
    PrintAyirac("Bütün Ürünlerin Fiyat Toplamını yazdırınız.");
    double total = 0;
    foreach (Product product in products)
    {
        total = total + product.Price;
    }

    Console.WriteLine($"Toplam : {total}");
}

void GetAllPriceRange(double min, double max)
{

    PrintAyirac($"{min} ile {max} değer aralığındaki ürünler : ");
    foreach (Product product in products)
    {
        if (product.Price>=min && product.Price <=max)
        {
            Console.WriteLine(product);
        }
    }
}


void GetPriceRangeData(out double min, out double max)
{
    Console.WriteLine("Lütfen minimum değeri giriniz: ");
     min = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Lütfen Max değeri giriniz: ");
    max = Convert.ToDouble(Console.ReadLine());
}

void GetAllProductsByPriceFiltered()
{
    double min;
    double max;
    GetPriceRangeData(out min, out max);
    GetAllPriceRange(min,max);
}

void GetAllProductNameContains()
{
    PrintAyirac("Ürün ismine göre filtrelenen ürünler");
    string text = GetProductNameData();
    foreach (Product product in products)
    {
        if (product.Name.Contains(text,StringComparison.InvariantCultureIgnoreCase))
        {
            Console.WriteLine(product);
        }
    }
}

string GetProductNameData()
{
    Console.WriteLine("Lütfen aramak istediğiniz ürünü yazınız: ");
    string text = Console.ReadLine();
    return text;
}


void DeleteProduct()
{
    PrintAyirac("Silme İşlemi");
    Console.WriteLine("Lütfen Ürün Id yi giriniz : ");
    int id = Convert.ToInt32(Console.ReadLine());

    bool isPresent = false;

    foreach (Product product in products)
    {
        if (product.Id == id)
        {
            products.Remove(product);
            isPresent = true;
            break;
        }
        else
        {
            isPresent = false;
          
        }
    }

    if (!isPresent)
    {
        Console.WriteLine($"Aradığınız id ye göre bir ürün bulunamadı: {id}");
        return;
    }

    foreach (Product item in products)
    {
        Console.WriteLine(item);
    }

}


