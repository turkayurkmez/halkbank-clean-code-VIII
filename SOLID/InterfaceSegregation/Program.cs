// See https://aka.ms/new-console-template for more information
using InterfaceSegregation;

Console.WriteLine("Hello, World!");
/*
 * Eğer bir sınıf implemente ettiği interface'in tüm fonksiyonlarını kullanmıyorsa,
 * o (kullanılmayan) fonksiyon o interface'de bulunmamalı, bir başkasına taşınmalı.
 */

ProductRepository productRepository = new ProductRepository();
OrderRepository orderRepository = new OrderRepository();
Searcher searcher = new Searcher();
searcher.Search(productRepository, "A");
