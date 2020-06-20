Projede Kullandığım Tasarım Desenleri : 
RepositoryPattern : Veritabanı Erişimi ve Veritabanı Erişim Kısmının Projeden Soyutlanması İçin Kullandım
DTOPattern : Entityleri Requeste Göndereceğimiz Modellere Dönüştürmek İçin Kullandım 
Kullanılan Teknoloji Ve Kütüphanler Hakkında Uygulama Geliştirme Seviyesinde Bilgim Var. Profesyonel olarak kullanmadım.
Daha geniş vaktim olsaydı loglama ve token mekanizması eklemek isterdim, Repositoryi Generic Olarak Oluşturmak İsterdim 

Route Yapısı : 
~/api/Article :Bütün Verileri Listeler,
~/api/Article/Get/{id} : Gönderilen id'ye Ait Makaleyi Getirir
~/api/Article/AddArticle : Body'de Gönderilen Modeli VeriTabanına Ekler
~/api/Article/UpdateArticle/{id}  :Parametrede Gelen id'ye Ait Kaydı Body'de Gönderilen Model Olarak Günceller
~/api/Article/RemoveArticle/{id} : Parametrede Gönderilen id'ye Ait Kaydı Siler
~/api/Article/Search/{Content} : Parametrede Gönderilen Değeri İçeren Kayıtları Listeler
