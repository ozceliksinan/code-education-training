import java.util.ArrayList;
import java.util.List;
import java.util.Set;
import java.util.TreeSet;
class Player implements Comparable<Player>{
    private String isim;
    
    private int id;

    public Player(String isim, int id) {
        this.isim = isim;
        this.id = id;
    }

    @Override
    public String toString() {
       return "|||| ID: " + id + " İsim :" + isim + " |||";
       
    }

    @Override
    public int compareTo(Player player) {

        if (this.id < player.id) {
            
            return -1;
            
        }
        else if (this.id > player.id) {
            return 1;
            
        }
        return 0;
        


    }
    

    
}
public class Main {
    public static void main(String[] args) {
        
       /* List<String> list_string = new ArrayList<String>();
        
        
        list_string.add("Java");
        list_string.add("C++");
        list_string.add("Python");
        list_string.add("Php");
        list_string.add("Go");
        
        Collections.sort(list_string);
        
        for (String s : list_string) {
            System.out.println(s);
        }*/
       
        List<Player> list_player = new ArrayList<Player>();
        
        list_player.add(new Player("Sinan", 5));
        list_player.add(new Player("Test", 1));
        list_player.add(new Player("Deneme", 10));
        list_player.add(new Player("Temp", 4));
        
        Player p1 = new Player("Sinan", 5);
        Player p2 = new Player("Temp", 4);
        
       // System.out.println(p1.compareTo(p1));
        
        /*Collections.sort(list_player);
        
        for (Player p : list_player) {
            
            System.out.println(p);
            
        }*/
        
        Set<Player> treeset = new  TreeSet<Player>();
        
        treeset.add(new Player("Sinan", 5));
        treeset.add(new Player("Deneme", 1));
        treeset.add(new Player("Test", 10));
        treeset.add(new Player("Temp", 4));
        
        for (Player p : treeset) {
            System.out.println(p);
            
        }
        
        
    }

}



