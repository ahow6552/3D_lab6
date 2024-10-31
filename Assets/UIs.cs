using UnityEngine;
using UnityEngine.UI;

public class UIs : MonoBehaviour
{
   public Toggle toggle;
   public Slider slider;
   public TMPro.TMP_Dropdown dropdown;
   public Image image;

   void Update()
   {
       image.gameObject.SetActive(toggle.isOn);
      
       if (dropdown.value == 0)
       {
           image.color = Color.yellow;
       }
       else if (dropdown.value == 1)
       {
           image.color = Color.blue;
       }
       else if (dropdown.value == 2)
       {
           image.color = Color.red;
       }

       image.color = new Color(image.color.r, image.color.g, image.color.b, slider.value);
   }
  
}
