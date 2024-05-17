// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");
/*
 * Dependency: Bir varlığın bir başkasına bağlı olma durumu. Örnek: Mouse ve pil
 * Inversion: Tersine çevirmek.
 * 
 * Büyük sistem küçüğe değil;
 * Küçük sistem büyüğe bağımlı olsun
 * 
 */
WhatsAppSender whatsAppSender = new WhatsAppSender();
TelegramSender telegramSender = new TelegramSender();   
MailSender mailSender = new MailSender();

FileProcess process = new FileProcess(whatsAppSender);