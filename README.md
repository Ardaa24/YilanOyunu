# YilanOyunu

# Yılan Oyunu (Snake Game)

> Basit bir Windows Forms tabanlı **Yılan Oyunu** uygulaması — C# kullanılarak geliştirilmiş.

---

## İçindekiler

- [Proje Hakkında](#proje-hakkında)  
- [Özellikler](#özellikler)  
- [Kurulum & Çalıştırma](#kurulum--çalıştırma)  
- [Kullanım](#kullanım)  
- [Kod Yapısı](#kod-yapısı)  
- [Geliştirme Fikirleri](#geliştirme-fikirleri)  
- [Katkıda Bulunma](#katkıda-bulunma)  
- [Lisans](#lisans)  

---

## Proje Hakkında

Bu proje, klasik **Yılan Oyunu** (Snake Game) oyununu Windows Forms kullanarak C# ile uygulamayı amaçlar. Yılan yemleri yiyerek uzar, duvara ya da kendi gövdesine çarptığında oyun sona erer.

Projede temel oyun mantığı, yılanın yön kontrolü, yem yerleştirme, çarpışma kontrolü ve oyun döngüsü gibi öğeler yer alır.

---

## Özellikler

- Klavye ile **yön kontrolü** (ok tuşları)  
- Yılanın yem toplaması ve uzunluğunun artması  
- Duvara veya kendine çarpma kontrolü (oyun biter)  
- Puan takibi  
- Oyun yeniden başlatma imkânı  

---

## Kurulum & Çalıştırma

1. Bu repoyu klonlayın:

   ```bash
   git clone https://github.com/Ardaa24/YilanOyunu.git
Visual Studio kullanıyorsanız:

.sln dosyasını açın (örneğin YilanOyunu.sln)

Projeyi derleyin (Build)

Uygulamayı çalıştırın (Start / F5)

.NET Framework / .NET sürümünü kontrol edin:

Proje Windows Forms kullandığı için uyumlu bir .NET Framework sürümü ya da .NET Windows Forms destekleyen versiyonları gerektirebilir.

Kullanım
Oyuna başlamadan önce yön tuşları ile yılanı kontrol edebilirsiniz.

Yılan, yemleri yedikçe uzar ve puanınız artar.

Eğer yılan duvara ya da kendine çarparsa oyun sona erer.

Oyun bittiğinde yeniden başlatabilirsiniz.

Kod Yapısı
Projede dosyalar ve sınıflar yaklaşık şöyle organize edilmiştir:

Program.cs — Uygulamanın başlangıç noktası

Form1.cs, Form1.Designer.cs — Windows Forms arayüzü ve olay işleyicileri

moveBLL.cs — Yılanın hareket mantığı

devBLL.cs — Geliştirme / iş mantığı

YilanOyunu.sln — Çözüm dosyası

Her modül kendi görevine odaklanmış olup, kodların anlaşılabilir olması amaçlanmıştır.

Geliştirme Fikirleri
Aşağıda projeye eklenebilecek bazı geliştirme önerileri:

Farklı zorluk seviyeleri (hız artışı)

Duvarın sınır dışı olması — yılan duvardan geçerek karşı taraftan çıkabilme

Grafik iyileştirmeleri, animasyonlar

Yılanın renkleri ya da yem tipleri

Yüksek puan tablosu

Ses efektleri

Katkıda Bulunma
Repoyu fork’layın

Kendi özelliğinizi / düzeltmenizi yapın

Pull request açın

Değişiklikler incelenecek, uygunsa projeye dahil edilecektir

Lisans
Bu proje MIT Lisansı altında sunulmaktadır. Daha fazla bilgi için LICENSE dosyasına bakabilirsiniz.

perl
Kodu kopyala

Eğer istersen ben bu README’yi senin repoya doğrudan ekleyecek biçime (örneğin detaylandırılmış, Türkçe/İngilizce versiyon) dönüştürürüm, ister misin o hâlini göndereyim?
::contentReference[oaicite:0]{index=0}
