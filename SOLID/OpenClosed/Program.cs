// See https://aka.ms/new-console-template for more information
using OpenClosed;

Console.WriteLine("Hello, World!");
/*
 * Bir nesne .....GELİŞİME..... açık .....DEĞİŞİME... kapalı olmalıdır.
 * 
 * 
 */

DocumentStorageManager storageManager = new DocumentStorageManager();
Document documentCatalog = new Document() {  Type = new PPTDocument(), Title="Oryantasyon"};
storageManager.ArchiveToServer(documentCatalog);
