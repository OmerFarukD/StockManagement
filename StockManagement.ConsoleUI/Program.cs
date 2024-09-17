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

// kullanıcıdan iki değer alalım bu değerler min ve max değerleri olsun
// bu 2 değer arasında stok verilerini getirsin.

// ürünler listesinde bir isim parametresi alarak ürün isimlerinden uyuşanları listelesin

// Kullanıcı bir Id girdiği zaman o id ye göre kitabı silen ve yeni listeyi ekrana bastıran
// kodu yazınız.


// Kullanıcıdan ilk başta id değeri alıp arama yaptıktan sonra eğer o Id ye ait
// bir kitap yoksa "İlgili Id ye ait bir kitap bulunamadı."
//* Güncellenecek olan değerler kullanıcıdan alınacak.

// Kullanıcıdan bir kitap almasını isteyen kodu yazınız 
// Eğer o kitap Stok da varsa kitap alındı yazısı çıksın 
// 1 tane varsa o kitap alınsın ve 0 olursa Listeden silinsin.


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

AddProductAndGetAll();




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