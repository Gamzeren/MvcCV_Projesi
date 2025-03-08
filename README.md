# 🎀 MVC5 ile Admin Panelli Dinamik CV Sitesi
Bu repo, Udemy üzerinden Murat Yücedağ hocanın vermiş olduğu "MVC5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi" eğitimini tamamladıktan sonra geliştirdiğim projeyi içermektedir. Bu proje, ASP.NET MVC5 mimarisi kullanılarak oluşturulmuş olup, admin paneli sayesinde içeriklerin kolayca yönetilebildiği dinamik bir CV sitesidir.
## 💎 Projenin Amacı
Bu proje, ASP.NET MVC5 mimarisi kullanılarak geliştirilmiş, admin paneli tarafından yönetilebilen dinamik bir CV sitesidir. Kullanıcı dostu arayüzü sayesinde, yönetici içerikleri kolayca güncelleyebilir ve web sitesinde dinamik değişiklikler yapabilir.
## 🚀 Kullanılan Teknolojiler
🔹ASP.NET MVC5: Web Uygulama Mimarisi </br>
🔹Entity Framework: Veritabanı işlemleri için ORM </br>
🔹SQL Server: Veritabanı Yönetimi </br>
🔹LINQ: Veri sorgulama işlemleri </br>
🔹Bootstrap: Duyarlı (Responsive) tasarım </br>
🔹HTML5, CSS3, JAVASCRIPT: Ön Yüz Geliştirme Teknolojileri </br>
## ✨ Proje Detayları
## ⭐️ Login Paneli
Kullanıcılar, sisteme giriş yapabilmek için kendilerine tanımlanmış kullanıcı adı ve şifreyi kullanmalıdır. Yetkilendirilmemiş kullanıcıların girişleri başarısız olacak ve LogIn sayfasına yönlendirilecektir. Giriş yapmadan yalnızca CV Sitesi ve LogIn sayfalarına erişilebilir. Başarılı giriş yapan kullanıcılar, Admin Paneline erişerek kişisel bilgilerini ekleyebilirler. Admin Panelindeki hiçbir alana, giriş yapılmadan doğrudan ulaşılamaz.

![Image](https://github.com/user-attachments/assets/78caac02-abf5-49ae-915c-fa46d645e6be)

## 🔒 Admin Paneli
### ⭐️ Hakkımda Sayfası
"Hakkımda" bölümünde, veri tabanındaki TblHakkimda tablosundaki veriler görüntülenmektedir. Kullanıcı, textBox alanlarında değişiklik yaptıktan sonra "Güncelle" butonuna tıklarsa, güncellenen bilgiler veri tabanına kaydedilecektir.

![Image](https://github.com/user-attachments/assets/168aafa7-ae99-40f0-84e4-1c297e28e48d)

### ⭐️ Eğitimlerim Sayfası
"Eğitimlerim" bölümünde veri tabanı üzerindeki TblEgitimlerim tablosundaki verileri görüntülemekteyiz. Burada bulunan "Yeni Eğitim Ekle" butonu ile yeni bir sayfaya gidip veri tabanına yeni bir eğitim ekleyebiliriz. "Güncelle" butonuna tıklarsak hangi satırdaki butona tıkladığımıza göre o satırdaki bilgiler eğitim güncelleme sayfasına taşınır ve o sayfada bize güncelleme yapma imkanı sunar. TextBox araçlarında yapılan değişiklikler sonucu "Güncelle" butonuna tıklanırsa veriler veri tabanı üzerinde güncellenecektir. "Sil" butonuna tıklanırsa hangi satırdaki sil butonu kullanıldıysa o satırdaki veriler veri tabanından silinecektir.

![Image](https://github.com/user-attachments/assets/49321db1-b439-43a0-96bb-d5091723fa87)

### ⭐️ Deneyimlerim Sayfası
"Deneyimlerim" bölümünde veri tabanı üzerindeki TblDeneyimlerim tablosundaki verileri görüntülemekteyiz. Burada bulunan "Yeni Deneyim Ekle" butonu ile yeni bir sayfaya gidip veri tabanına yeni bir deneyim ekleyebiliriz. "Güncelle" butonuna tıklarsak hangi satırdaki butona tıkladığımıza göre o satırdaki bilgiler deneyim güncelleme sayfasına taşınır ve o sayfada bize güncelleme yapma imkanı sunar. TextBox araçlarında yapılan değişiklikler sonucu "Güncelle" butonuna tıklanırsa veriler veri tabanı üzerinde güncellenecektir. "Sil" butonuna tıklanırsa hangi satırdaki sil butonu kullanıldıysa o satırdaki veriler veri tabanından silinecektir.

![Image](https://github.com/user-attachments/assets/b7342a2f-029c-4749-98ea-b0666f0deb7e)

### ⭐️ Hobilerim Sayfası
"Hobilerim" bölümünde veri tabanı üzerindeki TblHobilerim tablosundaki verileri görüntülemekteyiz. Burada textArea araçlarında yapılan değişiklikler sonucu "Güncelle" butonuna tıklanırsa veriler veri tabanı üzerinde güncellenecektir.

![Image](https://github.com/user-attachments/assets/cc018511-2cdc-47a9-956f-46f5d07cb08d)

### ⭐️ Yeteneklerim Sayfası
"Yeteneklerim" bölümünde veri tabanı üzerindeki TblYeteneklerim tablosundaki verileri görüntülemekteyiz. Yeteneklerin yanında hangi oranda o yetenekte başarlı olduğuma dair bir bar bulunmakatdır. Burada bulunan "Yeni Yetenek Ekle" butonu ile yeni bir sayfaya gidip veri tabanına yeni bir yetenek ekleyebiliriz. "Güncelle" butonuna tıklarsak hangi satırdaki butona tıkladığımıza göre o satırdaki bilgiler yetenek güncelleme sayfasına taşınır ve o sayfada bize güncelleme yapma imkanı sunar. TextBox araçlarında yapılan değişiklikler sonucu "Güncelle" butonuna tıklanırsa veriler veri tabanı üzerinde güncellenecektir. "Sil" butonuna tıklanırsa hangi satırdaki sil butonu kullanıldıysa o satırdaki veriler veri tabanından silinecektir.

![Image](https://github.com/user-attachments/assets/e2ace0ed-171f-4c7d-b1cb-902e87440252)

### ⭐️ Sertifikalarım Sayfası
"Sertifikalarım" bölümünde veri tabanı üzerindeki TblSertifikalarım tablosundaki verileri görüntülemekteyiz. Burada bulunan "Yeni Sertifika Ekle" butonu ile yeni bir sayfaya gidip veri tabanına yeni bir sertifika ekleyebiliriz. "Güncelle" butonuna tıklarsak hangi satırdaki butona tıkladığımıza göre o satırdaki bilgiler sertifika güncelleme sayfasına taşınır ve o sayfada bize güncelleme yapma imkanı sunar. TextBox araçlarında yapılan değişiklikler sonucu "Güncelle" butonuna tıklanırsa veriler veri tabanı üzerinde güncellenecektir. "Sil" butonuna tıklanırsa hangi satırdaki sil butonu kullanıldıysa o satırdaki veriler veri tabanından silinecektir.

![Image](https://github.com/user-attachments/assets/4baae756-386f-4e6c-98db-da3c32c03ea1)

### ⭐️ İletişim Sayfası
"İletişim" bölümünde veri tabanı üzerindeki TblIletisim tablosundaki verileri görüntülemekteyiz. Burada bulunan veriler CV sayfasında sayfamı ziyaret eden kişilerin bana gönderdiği mesajlardır. Bu veriler de yine veri tabanı üzerinde tutulmaktadır. Tüm mesajları bu bölümden görüntüleyebiliriz.

![Image](https://github.com/user-attachments/assets/7040291b-794a-4d96-82f2-4078b6281902)

### ⭐️ Sosyal Medya Sayfası
"Sosyal medya" bölümünde CV sayfasındaki Hakkımda bölümünde bulunan sosyal medya hesap bağlantılarının olduğu bölüm ile ilgili bilgiler tutulmaktadır. Burada bulunan "Yeni Sosyal Medya Hesabı Ekle" butonu ile Popup açıp onun üzerinden veri tabanına yeni bir sosyal medya hesabı ekleyebiliriz. "Güncelle" butonuna tıklarsak hangi satırdaki butona tıkladığımıza göre o satırdaki bilgiler sosyal medya hesabı güncelleme sayfasına taşınır ve o sayfada bize güncelleme yapma imkanı sunar. TextBox araçlarında yapılan değişiklikler sonucu "Güncelle" butonuna tıklanırsa veriler veri tabanı üzerinde güncellenecektir. "Sil" butonuna tıklanırsa hangi satırdaki sil butonu kullanıldıysa o satırdaki veriler pasif duruma alınır. CV sayfası üzerinde ise yalnızca aktif durumdaki sosyal medya hesapları bulunur. Veri tabanında sosyal medya sitesinin adı, link'i ve ikonu bulunmaktadır.

![Image](https://github.com/user-attachments/assets/e0afb47f-9b96-47a4-b659-e10924239d70)

![Image](https://github.com/user-attachments/assets/969dbfd5-b88e-46b1-b15e-a30795f022ed)

### ⭐️ Çıkış Bölümü
Çıkış bölümüne tıklandığında kullanıcı LogIn formuna geri döndürülecektir ve hesabı doğrulanmamış duruma alınacaktır.
### ⭐️ Siteye Git Bölümü
"Siteye Git" Butonu ile site ziyaret edilebilir.

## 💫 CV Paneli
Bu sayfada Hakkımda, Deneyimlerim, Eğitim Hayatım, Yeteneklerim, Hobilerim, Sertifikalarım ve İletişim bölümlerini tasarladım. Buradaki bilgileri kendime göre düzenledim. Bu bölümler veri tabanı ile doğrudan bağlantılı bir şekilde bilgileri MSSQL veritabanı üzerinden çekmektedir.

#### 🔸 Hakkımda Bölümü
![Image](https://github.com/user-attachments/assets/c1333aad-e8cd-473f-9d31-4cf5a3fe414b)

#### 🔸 Deneyimlerim Bölümü

![Image](https://github.com/user-attachments/assets/4d3e04d6-fb9b-4a4b-b162-f5a0d9d7dda5)

#### 🔸 Eğitim Hayatım Bölümü

![Image](https://github.com/user-attachments/assets/adf8ad9b-7108-4b67-8eb6-2c114ac40bb4)

#### 🔸 Yeteneklerim Bölümü

![Image](https://github.com/user-attachments/assets/4645f9ee-7d0f-4f08-b928-6b315453c690)

#### 🔸 Hobilerim Bölümü

![Image](https://github.com/user-attachments/assets/665b8bf5-7ffc-41fe-a9a7-c4ca70a41702)

#### 🔸 Sertifikalarım Bölümü

![Image](https://github.com/user-attachments/assets/6a983e8e-bee2-4826-bb3e-f60c7fb1a29d)

#### 🔸 İletişim Bölümü

![Image](https://github.com/user-attachments/assets/3d651bd9-c439-4d96-a419-fbe1928aaab4)
