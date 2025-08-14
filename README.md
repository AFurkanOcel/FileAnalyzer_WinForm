# File Analyzer
Kullanıcıların seçtikleri dosyaları analiz ederek karakter sayısı, satır sayısı, kelime bilgisi ve noktalama istatistiklerini sunan Windows Forms uygulaması.

![File Analyzer Ekran Görüntüsü](C:\Users\Furkan\Desktop\file.png)  
![File Analyzer Ekran Görüntüsü 2](C:\Users\Furkan\Desktop\file.png)  

## Özellikler
- **Opsiyonel giriş sistemi** (Login / Sign Up).
- **Desteklenen dosya türleri**: `.txt`, `.docx`, `.pdf` (checkbox ile seçim yapılabilir).
- **Dosya seçme**: Seçilen dosyanın yolu ekranda görüntülenir.
- **Analiz işlemi**:  
  - Karakter sayısı  
  - Satır sayısı  
  - Farklı kelime sayısı  
  - Tekrar eden kelimeler ve sayıları  
  - Noktalama işaretleri ve sayıları  
- **İlerleme çubuğu (Progress Bar)** ile analiz sürecinin görselleştirilmesi.
- **Sonuçları dışa aktarma**: `.txt` veya `.json` formatında export edilebilir.

## Kullanım
1. Uygulama açıldığında opsiyonel olarak giriş (Login / Sign Up) ekranı gelir.
2. Giriş yaptıktan sonra **File Analyzer** ekranına yönlendirilirsiniz.
3. Checkbox'lardan analiz etmek istediğiniz dosya türlerini seçin.
4. **Select File** butonuna tıklayarak dosya seçin.
5. Dosya yolu ekranda görüntülendikten sonra **Analyze** butonuna basın.
6. Analiz tamamlandığında sonuçlar ekranda listelenir.
7. **Export** butonuna tıklayarak `.txt` veya `.json` formatında kaydedin.

## Gereksinimler
- Windows işletim sistemi
- .NET Framework / .NET 6+
- Microsoft Word yüklü olmalıdır (`.docx` desteği için)

## Lisans
Bu proje MIT lisansı ile lisanslanmıştır.
