 /**
 *
 * @author Sinan Özçelik
 */
public abstract class Sekil {
    
    private String isim;

    public Sekil(String isim) {
        this.isim = isim;
    }
    
    public void ismini_soyle() {
        
        
        System.out.println("Bu obje " + isim + " objesidir.");
    }
    abstract void alan_hesapla(); 
    // Daire ve kare şekillerinde alanlar farklı hesaplandığı için boş bıraktık. İki şekilde de farklı hesaplamalar vardır.

    public String getIsim() {
        return isim;
    }

    public void setIsim(String isim) {
        this.isim = isim;
    }
    
}
