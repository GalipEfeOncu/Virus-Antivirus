# 🛡️ Süreç Yönetimi ve Antivirüs Simülasyonu

Bu proje, C# ve Windows Forms kullanılarak geliştirilen, sistem süreçlerinin (process) nasıl izlendiğini ve yönetildiğini gösteren iki parçalı bir eğitim uygulamasıdır.

## 📂 Proje İçeriği

### 1. Hayalet Virüs (Simülasyon Hedefi)
Tamamen zararsız bir şaka yazılımıdır.
* **Dinamik Hareket:** Ekranın rastgele konumlarında, rastgele boyutlarda belirir.
* **Hayalet Modu:** 3 saniye görünür, 1 saniye gizlenir (Hide/Show döngüsü).
* **Görsel:** Arka plan rengini sürekli değiştirerek dikkat çeker.

### 2. Basit Antivirüs (Tarayıcı)
Hedef uygulamayı tespit edip sonlandıran araçtır.
* **Tarama:** `System.Diagnostics` kütüphanesi ile aktif çalışan tüm işlemleri tarar.
* **Tespit:** Virüsü işlem adından (.exe isminden) yakalar.
* **Müdahale:** Kullanıcı onayı ile zararlı süreci güvenli bir şekilde sonlandırır (Kill).

## 🚀 Nasıl Çalıştırılır?

1. Önce **Virus** projesini derleyip çalıştırın (Ekranda yanıp sönen pencere açılacak).
2. Ardından **Antivirüs** uygulamasını başlatın.
3. **"Tara"** butonuna basın.
4. Tespit edilen virüsü silmek için gelen uyarıya **"Evet"** deyin.

## 🛠 Kullanılan Teknolojiler

* C# .NET Windows Forms
* `System.Diagnostics.Process` (Süreç Yönetimi)
* `System.Windows.Forms.Timer` (Zamanlayıcılar)
