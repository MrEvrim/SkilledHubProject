using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMesh Pro namespace'i

public class SwitchCameraCanvas : MonoBehaviour
{
    public Button switchButton;
    public Camera cameraToDisable;
    public Camera cameraToEnable;
    public Canvas canvasToDisable;
    public Canvas canvasToEnable;

    public TMP_InputField nameInputField;
    public TextMeshProUGUI nameDisplayText;

    void Start()
    {
        switchButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        // boş ise başlatma
        if (!string.IsNullOrWhiteSpace(nameInputField.text))
        {
            SwitchComponents();
        }
    }

    void SwitchComponents()
    {
        // Kamera ve Canvas aktiflik durumları
        cameraToDisable.gameObject.SetActive(false);
        cameraToEnable.gameObject.SetActive(true);
        canvasToDisable.gameObject.SetActive(false);
        canvasToEnable.gameObject.SetActive(true);

        if (nameInputField != null && nameDisplayText != null)
        {
            string name = nameInputField.text;

            nameDisplayText.text = $"Uzun zaman önce, hayallerle dolu hareketli bir şehirde....\r\n\r\nSKILLED HUB\r\n\r\n<align=center>BÖLÜM  I\r\n<size=50>BİR GELİŞTİRİCİNİN YÜKSELİŞİ</size></align>\r\n\r\nBu, yeniliklerin zamanı. Tutkularıyla hareket eden hevesli oyun geliştiricileri, bir sonraki büyük hiti yaratmak için çabalıyorlar.\r\n\r\nOnların arasında, genç bir kodlayıcı olan <color=red>{name}</color>, ilk oyun jam'ini kazanmış, indie oyun topluluğunda saygı ve takdir kazanmıştı.\r\n\r\nBu yolculuk sırasında, <color=red>{name}</color>, basit fikirleri çığır açan oyunlara dönüştürebilen güçlü bir araç olan SKILLED HUP'u keşfetti. Ancak, bu aracı ustalıkla kullanmak için <color=red>{name}</color>, sayısız zorluğun üstesinden gelmeli, her satır kodla birlikte öğrenip büyümeliydi.\r\n\r\nŞimdi, dünyada iz bırakacak bir oyun inşa etme hayaliyle, <color=red>{name}</color>, her engeli aşmaya ve vizyonunu hayata geçirmeye kararlı bir şekilde bir yolculuğa çıkıyor.";
        }
    }
}

