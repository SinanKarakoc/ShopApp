using System.Collections.Generic;
using shoppapp.webui.Models;
//burada using namespace yok. Virtual class olarak tanımlıyoruz aslında.
public class ProductViewModel
{
    //burada 2 farklı entity'yi paketlemiş olduk 2den fazlası da benzer şekilde paketlenebilir. 
    //Paketleme için 'ViewModel' kullanıyoruz.
    
    public List<ProductEntity> Products { get; set; }
}