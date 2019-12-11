using System;
using System.Windows.Forms;

namespace Kriptoloji_2.ödev_121180015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Calculate();
        }

       public void Calculate()
        {
            // Generate variables
            string s = @"Gregor Samsa bir sabah bunaltıcı düşlerden uyandığında, kendini yatağında dev bir böceğe dönüşmüş olarak buldu. Zırh gibi sertleşmiş sırtının üstünde yatmaktaydı ve başını biraz kaldırdığında bir kubbe gibi şişmiş,

kahverengi, sertleşen kısımların oluşturduğu yay biçimi çizgilerle parsellere ayrılmış karnını görüyordu; karnının tepesindeki yorgan neredeyse tümüyle yere kaymak üzereydi ve tutunabileceği hiçbir nokta kalmamış gibiydi. Gövdesinin çapıyla karşılaştırıldığında açması incelikteki çok sayıda bacak, gözlerinin önünde çaresizlik içersinde, parıltılar saçarak sallanıp durmaktaydı.
‘Ne olmuş bana böyle?’ diye düşündü. Gördüğü düş değildi. Biraz küçük, ama normal, yani içinde insanlar yaşasın diye yapılmış olan odası, ezbere bildiği dört duvarın arasında eskiden nasılsa, şimdi de yine öyleydi. Üstünde paketten çıkarılmış kumaş örneklerinin –Samsa’nın uğraşı pazarlamacılıktı– yayılı olduğu masanın üzerinde, kısa süre önce resimli bir dergiden kesip, altın yaldızlı güzel bir çerçeveye geçirmiş olduğu bir resim asılıydı. Kürk şapkalı ve kürk atkılı bir kadın vardı resimde; kadın, kollarının dirsekten aşağı kalan kısımlarını tümüyle içine alan ağır bir kürk manşonu, dimdik oturduğu yerden izleyiciye doğru kaldırır gibiydi.

Gregor daha sonra bakışlarını pencereye yöneltti ve kasvetli hava yüzünden –yağmur damlalarının pencerenin çinko pervazına çarptığı duyuluyordu– içini büyük bir hüzün kapladı. ‘Biraz daha uyusam ve bütün bu saçmalıkları unutsam, nasıl olur,’ diye düşündü, gelgeldim bunu gerçekleştirmesi tümüyle olanaksızdı, çünkü Gregor Samsa sağ yanına yatıp uyumaya alışkındı, oysa o andaki durumu kendini böyle bir konuma getirmesine izin vermiyordu. Sağına dönmek için ne denli güç harcarsa harcasın, yine sırtüstü konumuna geri dönüyordu. Başarmayı belki yüz kez denedi, çırpınan bacaklarını görmemek için gözlerini kapattı ve ancak yan tarafında o ana değin yabancısı olduğu, hafif, derinden gelen bir acı duymaya başladıktan sonradır ki, çabalamayı kesti.

‘Aman Tanrım,’ diye düşündü,’ ne kadar da yorucu bir uğraş seçmişim meğer!’ Günlerim hep yolculuk etmekle geçiyor, işin bu yanı, mağazadaki asıl masabaşı işine oranla çok daha yıpratıcı, üstelik benim için bir de yolculuğun aktarma trenlerin peşinden koşmak, düzensiz ve kötü yemeklere yargılı olmak, insanlarla sürekli değişen, asla süreklilik kazanamayan, hep içtenlikten uzak ilişkiler kurmak zorunluluğu gibi sıkıntıları da var. Şeytan alsın bütün bunları! Karnının üstünde hafif bir kaşıntı duyumsadı; başını daha iyi kaldırabilmek için, sırtüstü konumda ağır ağır yatağın başucuna doğru süründü; kaşınan yeri buldu; burada ne olduğunu anlayamadığı bir sürü küçük ve beyaz nokta vardı; ayaklarından birini oraya dokundurmak istediyse de, hemen geri çekti, çünkü değmesiyle birlikte her yanını bir titreme nöbeti kaplamıştı.

Yine eski konumuna kaydı.’ Bu erken kalkma yok mu,’ diye düşündü, insanı aptala çeviriyor. İnsanın uykusunu alması gerekir. Başka pazarlamacılar harem kadınları gibi yaşıyorlar. Örneğin ben aldığım siparişleri firmaya iletmek üzere öğlenden önce otele döndüğümde, ötekiler daha kahvaltıda oluyorlar. Ben patronuma böyle bir şey yapmaya kalkışsam, hemen o anda kapı dışarı edilirim.

Ama kimbilir, belki de çok iyi olurdu böyle bir şey benim için. Annemle babam yüzünden kendimi tutuyor olmasaydım eğer, işimden çoktan ayrılırdım, patrona çıkar ve ne düşündüğümü olduğu gibi söylerdim. O zaman kürsüsünden düşerdi herhalde! Üstelik kürsüye oturup çalışanlarla öyle, yani yüksekten konuşmakta başlı başına tuhaf bir davranış, hele kendisiyle konuşulan görevlinin, patronun kulağının ağır işitmesi nedeniyle kürsüye iyice yaklaşmak zorunda olduğu da göz önünde tutulursa. Öte yandan, henüz tüm ümitlerin yitirilmiş olduğu da söylenemez; annemle babamın patrona olan borçlarını ödemeye yetecek olan parayı bir kez biriktirdim mi –ki daha beş, altı yıl sürebilir bu-, o zaman mutlaka yapacağım düşündüğümü. İşi kökünden bitireceğim. Ama şimdilik yataktan çıkmak zorundayım, çünkü trenim saat beşte kalkıyor.

Ve gece masasının üstünde işlemekte olan saate baktı.’ Aman Tanrım l’diye düşündü. Saat altı buçuktu ve akreple yelkovanın ilerleyişi sürmekteydi, saat buçuğu bile geçmiş, yediye çeyrek kalaya yaklaşmıştı. Yoksa çalmamış mıydı saat ? Yataktan, saatin doğru, yani dörde kurulmuş olduğu görülüyordu; hiç kuşkusuz çalmıştı da. Evet ama, çaları, eşyaları yerinden oynatacak denli güçlü olan saati duymayıp uyumayı sürdürmüş olması düşünülebilir miydi? Gerçi sakin uyumuş olduğu söylenemezdi, ama herhalde o ölçüde de derin olmuştu uykusu. Peki şimdi ne yapacaktı? Bundan sonraki tren saat yedide kalkıyordu, o trene yetişebilmek için deli gibi acele etmesi gerekirdi, üstelik kumaş örnekleri de daha sarılmamıştı ve Gregor Samsa kendini hiç de çok dinlenmiş, çok canlı duyumsamıyordu. Trene yetişse bile, patronun bir öfke nöbetine yakalanmasını önleyemezdi, çünkü onu karşılamak için saat beş trenini beklemiş olan ve mağazanın ayak işlerine bakan görevli, onun treni kaçırdığını patrona çoktan haber vermiş olmalıydı. Patronun kayıtsız şartsız uşağı olan bu adamda ne kişilik, ne de akıl vardı. Peki, hasta olduğunu söyleyip işe gitmese? Böylesi, çok nahoş ve kuşku uyandırıcı bir davranış olurdu, çünkü Gregor beş yıllık hizmeti boyunca bir kez bile hastalanmamıştı.

Patron, kesinlikle yanına sigorta doktorunu da alıp gelir, annesiyle babasını oğullarının tembelliğinden ötürü suçlar ve tüm itirazları sigorta doktoruna atıfta bulunarak geçersiz kılardı; bu doktora göre dünyada yalnızca son derece sağlıklı, ama işten kaçan insanlar vardı. Ama doktor, şimdi kendisinin olayında tümüyle haksız sayılabilir miydi? Çünkü Gregor, uzun bir uykunun ardından hakikaten gereksiz bir mahmurluğun dışında, kendini çok iyi hissediyordu ve üstelik çok da büyük bir iştahı vardı. Gregor bütün bunları, yataktan çıkıp çıkmama konusunda bir karara varmaksızın, hızla kafasından geçirdiği sırada –saat yediye çeyrek kalayı vurmuştu-, yatağının başucundaki kapıya dikkatle vuruldu. “Gregor,” diye seslendi bir ses – annesiydi-, “saat yediye çeyrek var. Sen yola gitmeyecek miydin ?”0 yumuşak ses! Gregor, kendi yanıt veren sesini duyduğunda korktu, bunun eski sesi olduğu herhalde kesindi, ama bu sese alttan alta bastırılması olanaksız, acı bir ıslık da karışıyor ve bu ıslık, sözcüklerin netliklerini ancak ilk anda koruyor, hemen ardından sözcükleri karşıdakini kulaklarına inanamaz kılacak denli bozuyordu. Gregor aslında ayrıntılı yanıt vermek ve her şeyi açıklamak istiyordu, ama bu koşullar altında “Evet, evet, teşekkür ederim anne, şimdi kalkıyorum,” demekle yetindi.

Aradaki ahşap kapı nedeniyle Gregor’un sesindeki değişiklik herhalde dışardan anlaşılmıyordu, çünkü annesi bu açıklamayı yeterli görerek uzaklaştı. Ancak bu kısa söyleşi, Gregor’un, normalin tersine, hâlâ evde olduğu noktasına ailenin öteki üyelerinin dikkatini çekmişti ve babası, odanın iki yandaki kapılarından birine gerçi yavaş, ama yine de yumruğuyla vurmaya başlamıştı bile. “Gregor, Gregor,”diye seslendi, “Ne oldu?” Ve kısa bir süre sonra, daha derinden gelen bir sesle, yine uyardı: “Gregor! Gregor!”Öteki kapının arkasında ise kızkardeşi, alçak sesle yakınıyordu: “Gregor? İyi değil misin yoksa? Bir isteğin var mı?” Gregor her iki yana da: “Tamam, hazırım,” diye yanıt verdi ve sözcüklerin arasına uzun aralar sokarak, sesinin tüm çarpıcı yanlarını gidermeye çalıştı. Bunun sonucunda babası kahvaltısının başına döndü, ama kızkardeşi fısıldamayı sürdürüyordu: “Gregor, yalvarırım aç kapıyı.” Oysa Gregor kapıyı açmayı aklının ucundan bile geçirmiyordu, tersine, yolculukları sırasında edinmiş olduğu bir alışkanlığı, evde bile olsa gece bütün kapıları kilitleme alışkanlığını övmekteydi.

Niyeti, önce sakin sakin ve kimse tarafından rahatsız edilmeksizin kalkmak, doğru dürüst kahvaltı etmek ve ne yapacağına ancak ondan sonra karar vermekti; çünkü yatakta düşünerek mantıklı bir sonuca ulaşamayacağını artık iyice anlamıştı. Daha önce de çoğu kez, belki de yatakta biçimsiz yatmaktan kaynaklanan, hafif bir sızı duyduğunu, ama kalktıktan sonra bunun kuruntudan başka bir şey olmadığını anladığını anımsıyordu; şimdi merakı, bugünkü kuruntularının nasıl dağılacağıydı. Sesindeki değişikliğin şiddetli bir soğuk algınlığının, yani ömürleri yollarda geçenlere özgü bir meslek hastalığının öncüsü olduğundan hiç kuşkusu yoktu. Yorganı üstünden atmak çok kolaydı; gövdesini biraz şişirince, yorgan kendiliğinden aşağı düştü. Ama işin ondan sonrası, özellikle gövdesinin bu denli geniş olması nedeniyle, güçleşmişti. Doğrulabilmek için kollarının ve ellerinin varlığı gerekliydi, gelgelelim onların yerine sürekli en değişik hareketleri sergileyen, üstelik de hareketlerini denetimi altına alamadığı bir sürü minik bacağı vardı. Bacaklardan birini kıvırmak istediğinde aldığı ilk sonuç, bu bacağın ileri doğru uzanması oluyordu; ve sonunda bacağını istediği konuma getirmeyi basarsa bile, bu olana dek öteki bacakları, zincirden boşanmışçasına, son derece canlı ve acı verici bir hareketlilikle çırpınıp duruyorlardı.’önce böyle uyuşuk uyuşuk yatıp durmaya son vermeli,’dedi Gregor kendi kendine.";
            int[] c = new int[(int)char.MaxValue];
            string text = "";
            string ftextbox = "";
            string check = @"Enter the text for which you want to perform a frequency analysis.
If no text is entered, it will work with default text.";
            string result = "";

            // Check  text entered or not
            ftextbox = textBox2.Text.ToString();
            bool equlornot = check.Equals(ftextbox);
            if (equlornot)
            {
                text += s;
                // Console.WriteLine("Equal");// mean no text entered 
            }
            else if (!equlornot)//mean entered new text
            {
                text += textBox2.Text.ToString();
               // Console.WriteLine("Not Equal");// mean user entered new text
            }
            // Generating table
            foreach (char t in text)
            {
                c[(int)t]++;
            }

            // Generate letter frequency text result
            for (int i = 0; i < (int)char.MaxValue; i++)
            {
                if (c[i] > 0 &&
                    char.IsLetterOrDigit((char)i))
                {
                    result += "Letter : " + (char)i + " Frequency : " + c[i] + Environment.NewLine; 
                }
            }
            textBox1.Text = result;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
// Default Text
/*
    Gregor Samsa bir sabah bunaltıcı düşlerden uyandığında, kendini yatağında dev bir böceğe dönüşmüş olarak buldu. 
    Zırh gibi sertleşmiş sırtının üstünde yatmaktaydı ve başını biraz kaldırdığında bir kubbe gibi şişmiş,
kahverengi, sertleşen kısımların oluşturduğu yay biçimi çizgilerle parsellere ayrılmış karnını görüyordu;
karnının tepesindeki yorgan neredeyse tümüyle yere kaymak üzereydi ve tutunabileceği hiçbir nokta kalmamış gibiydi.
Gövdesinin çapıyla karşılaştırıldığında açması incelikteki çok sayıda bacak, gözlerinin önünde çaresizlik içersinde,
parıltılar saçarak sallanıp durmaktaydı.‘Ne olmuş bana böyle?’ diye düşündü. Gördüğü düş değildi.
Biraz küçük, ama normal, yani içinde insanlar yaşasın diye yapılmış olan odası, ezbere bildiği dört duvarın arasında eskiden 
nasılsa, şimdi de yine öyleydi.Üstünde paketten çıkarılmış kumaş örneklerinin –Samsa’nın uğraşı pazarlamacılıktı– 
yayılı olduğu masanın üzerinde, kısa süre önce resimli bir dergiden kesip, altın yaldızlı güzel bir çerçeveye geçirmiş 
olduğu bir resim asılıydı. Kürk şapkalı ve kürk atkılı bir kadın vardı resimde; kadın, kollarının dirsekten aşağı 
kalan kısımlarını tümüyle içine alan ağır bir kürk manşonu, dimdik oturduğu yerden izleyiciye doğru kaldırır gibiydi.

Gregor daha sonra bakışlarını pencereye yöneltti ve kasvetli hava yüzünden –yağmur damlalarının pencerenin
çinko pervazına çarptığı duyuluyordu– içini büyük bir hüzün kapladı. ‘Biraz daha uyusam ve bütün bu saçmalıkları 
unutsam, nasıl olur,’ diye düşündü, gelgeldim bunu gerçekleştirmesi tümüyle olanaksızdı, çünkü Gregor Samsa sağ yanına 
yatıp uyumaya alışkındı, oysa o andaki durumu kendini böyle bir konuma getirmesine izin vermiyordu. Sağına dönmek için ne 
denli güç harcarsa harcasın, yine sırtüstü konumuna geri dönüyordu. Başarmayı belki yüz kez denedi, çırpınan bacaklarını 
görmemek için gözlerini kapattı ve ancak yan tarafında o ana değin yabancısı olduğu, hafif, derinden gelen bir acı duymaya
başladıktan sonradır ki, çabalamayı kesti.

‘Aman Tanrım,’ diye düşündü,’ ne kadar da yorucu bir uğraş seçmişim meğer!’ Günlerim hep yolculuk etmekle geçiyor,
işin bu yanı, mağazadaki asıl masabaşı işine oranla çok daha yıpratıcı, üstelik benim için bir de yolculuğun aktarma 
trenlerin peşinden koşmak, düzensiz ve kötü yemeklere yargılı olmak, insanlarla sürekli değişen, asla süreklilik
kazanamayan, hep içtenlikten uzak ilişkiler kurmak zorunluluğu gibi sıkıntıları da var. Şeytan alsın bütün bunları! 
Karnının üstünde hafif bir kaşıntı duyumsadı; başını daha iyi kaldırabilmek için, sırtüstü konumda ağır ağır yatağın 
başucuna doğru süründü; kaşınan yeri buldu; burada ne olduğunu anlayamadığı bir sürü küçük ve beyaz nokta vardı; 
ayaklarından birini oraya dokundurmak istediyse de, hemen geri çekti, çünkü değmesiyle birlikte her yanını bir 
titreme nöbeti kaplamıştı.

Yine eski konumuna kaydı.’ Bu erken kalkma yok mu,’ diye düşündü, insanı aptala çeviriyor. İnsanın uykusunu alması
gerekir. Başka pazarlamacılar harem kadınları gibi yaşıyorlar. Örneğin ben aldığım siparişleri firmaya iletmek
üzere öğlenden önce otele döndüğümde, ötekiler daha kahvaltıda oluyorlar. Ben patronuma böyle bir şey yapmaya 
kalkışsam, hemen o anda kapı dışarı edilirim.

Ama kimbilir, belki de çok iyi olurdu böyle bir şey benim için. Annemle babam yüzünden kendimi tutuyor olmasaydım
eğer, işimden çoktan ayrılırdım, patrona çıkar ve ne düşündüğümü olduğu gibi söylerdim. O zaman kürsüsünden düşerdi 
herhalde! Üstelik kürsüye oturup çalışanlarla öyle, yani yüksekten konuşmakta başlı başına tuhaf bir davranış, hele
kendisiyle konuşulan görevlinin, patronun kulağının ağır işitmesi nedeniyle kürsüye iyice yaklaşmak zorunda olduğu da 
göz önünde tutulursa. Öte yandan, henüz tüm ümitlerin yitirilmiş olduğu da söylenemez; annemle babamın patrona olan
borçlarını ödemeye yetecek olan parayı bir kez biriktirdim mi –ki daha beş, altı yıl sürebilir bu-, o zaman mutlaka 
apacağım düşündüğümü. İşi kökünden bitireceğim. Ama şimdilik yataktan çıkmak zorundayım, çünkü trenim saat beşte kalkıyor.

Ve gece masasının üstünde işlemekte olan saate baktı.’ Aman Tanrım l’diye düşündü. Saat altı buçuktu ve akreple 
yelkovanın ilerleyişi sürmekteydi, saat buçuğu bile geçmiş, yediye çeyrek kalaya yaklaşmıştı. Yoksa çalmamış mıydı saat ? 
Yataktan, saatin doğru, yani dörde kurulmuş olduğu görülüyordu; hiç kuşkusuz çalmıştı da. Evet ama, çaları, eşyaları
yerinden oynatacak denli güçlü olan saati duymayıp uyumayı sürdürmüş olması düşünülebilir miydi? Gerçi sakin uyumuş 
olduğu söylenemezdi, ama herhalde o ölçüde de derin olmuştu uykusu. Peki şimdi ne yapacaktı? Bundan sonraki tren saat
yedide kalkıyordu, o trene yetişebilmek için deli gibi acele etmesi gerekirdi, üstelik kumaş örnekleri de daha sarılmamıştı
ve Gregor Samsa kendini hiç de çok dinlenmiş, çok canlı duyumsamıyordu. Trene yetişse bile, patronun bir öfke nöbetine
yakalanmasını önleyemezdi, çünkü onu karşılamak için saat beş trenini beklemiş olan ve mağazanın ayak işlerine bakan
görevli, onun treni kaçırdığını patrona çoktan haber vermiş olmalıydı. Patronun kayıtsız şartsız uşağı olan bu adamda
ne kişilik, ne de akıl vardı. Peki, hasta olduğunu söyleyip işe gitmese? Böylesi, çok nahoş ve kuşku uyandırıcı bir 
davranış olurdu, çünkü Gregor beş yıllık hizmeti boyunca bir kez bile hastalanmamıştı.

Patron, kesinlikle yanına sigorta doktorunu da alıp gelir, annesiyle babasını oğullarının tembelliğinden ötürü suçlar
ve tüm itirazları sigorta doktoruna atıfta bulunarak geçersiz kılardı; bu doktora göre dünyada yalnızca son derece sağlıklı,
ama işten kaçan insanlar vardı. Ama doktor, şimdi kendisinin olayında tümüyle haksız sayılabilir miydi? Çünkü Gregor,
uzun bir uykunun ardından hakikaten gereksiz bir mahmurluğun dışında, kendini çok iyi hissediyordu ve üstelik
çok da büyük bir iştahı vardı. Gregor bütün bunları, yataktan çıkıp çıkmama konusunda bir karara varmaksızın,
hızla kafasından geçirdiği sırada –saat yediye çeyrek kalayı vurmuştu-, yatağının başucundaki kapıya dikkatle vuruldu. 
“Gregor,” diye seslendi bir ses – annesiydi-, “saat yediye çeyrek var. Sen yola gitmeyecek miydin ?”0 yumuşak ses! 
Gregor, kendi yanıt veren sesini duyduğunda korktu, bunun eski sesi olduğu herhalde kesindi, ama bu sese alttan
alta bastırılması olanaksız, acı bir ıslık da karışıyor ve bu ıslık, sözcüklerin netliklerini ancak ilk anda koruyor,
hemen ardından sözcükleri karşıdakini kulaklarına inanamaz kılacak denli bozuyordu. Gregor aslında ayrıntılı yanıt 
vermek ve her şeyi açıklamak istiyordu, ama bu koşullar altında “Evet, evet, teşekkür ederim anne, şimdi kalkıyorum,”
demekle yetindi.

Aradaki ahşap kapı nedeniyle Gregor’un sesindeki değişiklik herhalde dışardan anlaşılmıyordu, çünkü annesi bu açıklamayı 
yeterli görerek uzaklaştı. Ancak bu kısa söyleşi, Gregor’un, normalin tersine, hâlâ evde olduğu noktasına ailenin öteki 
üyelerinin dikkatini çekmişti ve babası, odanın iki yandaki kapılarından birine gerçi yavaş, ama yine de yumruğuyla vurmaya 
başlamıştı bile. “Gregor, Gregor,”diye seslendi, “Ne oldu?” Ve kısa bir süre sonra, daha derinden gelen bir sesle, yine 
uyardı: “Gregor! Gregor!”Öteki kapının arkasında ise kızkardeşi, alçak sesle yakınıyordu: “Gregor? İyi değil misin yoksa? 
Bir isteğin var mı?” Gregor her iki yana da: “Tamam, hazırım,” diye yanıt verdi ve sözcüklerin arasına uzun aralar sokarak, 
sesinin tüm çarpıcı yanlarını gidermeye çalıştı. Bunun sonucunda babası kahvaltısının başına döndü, ama kızkardeşi 
fısıldamayı sürdürüyordu: “Gregor, yalvarırım aç kapıyı.” Oysa Gregor kapıyı açmayı aklının ucundan bile geçirmiyordu, 
tersine, yolculukları sırasında edinmiş olduğu bir alışkanlığı, evde bile olsa gece bütün kapıları kilitleme alışkanlığını 
övmekteydi.

Niyeti, önce sakin sakin ve kimse tarafından rahatsız edilmeksizin kalkmak, doğru dürüst kahvaltı etmek ve ne yapacağına 
ancak ondan sonra karar vermekti; çünkü yatakta düşünerek mantıklı bir sonuca ulaşamayacağını artık iyice anlamıştı.
Daha önce de çoğu kez, belki de yatakta biçimsiz yatmaktan kaynaklanan, hafif bir sızı duyduğunu, 
ama kalktıktan sonra bunun kuruntudan başka bir şey olmadığını anladığını anımsıyordu; şimdi merakı, 
bugünkü kuruntularının nasıl dağılacağıydı. Sesindeki değişikliğin şiddetli bir soğuk algınlığının, 
yani ömürleri yollarda geçenlere özgü bir meslek hastalığının öncüsü olduğundan hiç kuşkusu yoktu. 
Yorganı üstünden atmak çok kolaydı; gövdesini biraz şişirince, yorgan kendiliğinden aşağı düştü. Ama işin ondan sonrası,
özellikle gövdesinin bu denli geniş olması nedeniyle, güçleşmişti. Doğrulabilmek için kollarının ve ellerinin varlığı gerekli
ydi, gelgelelim onların yerine sürekli en değişik hareketleri sergileyen, üstelik de hareketlerini denetimi altına alamadığı 
bir sürü minik bacağı vardı. Bacaklardan birini kıvırmak istediğinde aldığı ilk sonuç, bu bacağın ileri doğru uzanması
oluyordu; ve sonunda bacağını istediği konuma getirmeyi basarsa bile, bu olana dek öteki bacakları, zincirden boşanmışçasına,
son derece canlı ve acı verici bir hareketlilikle çırpınıp duruyorlardı.’önce böyle uyuşuk uyuşuk yatıp durmaya son vermeli,’
dedi Gregor kendi kendine.

 */
