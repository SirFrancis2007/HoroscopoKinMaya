class Datos
{
    public string[] nombres;
    public int[] valores;

    public string[] Nombres
    {
        get
        {
            return nombres;
        }
        set
        {
            nombres = value;
        }
    }

    public int[] Valores
    {
        get
        {
            return valores;
        }
        set
        {
            valores = value;
        }
    }
}

class Usuario
{
    private string nombre;
    private DateTime fecha;
    private int valorAnio;
    private int valorMes;

    public string Nombre
    {
        get
        {
            return nombre;
        }
        set
        {
            nombre = value;
        }
    }

    public DateTime Fecha
    {
        get
        {
            return fecha;
        }
        set
        {
            fecha = value;
        }
    }

    public int ValorAnio
    {
        get
        {
            return valorAnio;
        }
        set
        {
            valorAnio = value;
        }
    }

    public int ValorMes
    {
        get
        {
            return valorMes;
        }
        set
        {
            valorMes = value;
        }
    }
}
class Descripcion
{
    public static string[] descripcion = new string[]
    {
 @"(El que nutre). Tienen un gran poderío físico. Están vinculados 
con el costado más material del universo.",
 @"(El comunicador). Buenos oradores y escritores, tienen 
la gran virtud de comunicarse con todo tipo de gente,
 y explicar cualquier causa por compleja que fuera",
 @"(El soñador). Cercanos siempre a la abundancia, 
están vinculados con la energía de los sueños, la magia y
 el misterio. Muy creativos, ayudan en su contexto.",
 @"(El jardinero). Pueden llegar con el consejo más oportuno 
o con la frase más desafortunada a quienes lo rodean.
 Pero son atentos y precisos con sus semejantes.",
 @"(El Instintivo). Les dicen así porque viven en estado físico, 
instinto y piel en su contexto. Tienen una 
 extraordinaria facilidad para percibir la salud o lo tóxico en quienes 
están frente a ellos.",
 @"(El puente). Son personas que tienen una especial cualidad para leer 
los momentos de crisis. Pese a los 
 golpes de los finales, saben enfocarse en las oportunidades del cambio.",
 @"(El sanador). Viven la vida con intensidad, con iguales dosis de 
acción y reflexión. Son sanadores por 
 excelencia de los demás: sea con sus manos o con sus palabras.",
 @"(El artista). Creativos como pocos, llegan al mundo con un especial 
don para las artes, sea la plástica,
 la pintura, el cine o la literatura. Pero además, hagan lo que hagan 
en sus vidas, lo harán de forma distintiva y original.",
 @"(El Sensible). Dotados de una gran sensibilidad y percepción del
alma de sus semejantes, tienden a cuidar a quienes los rodean. 
Especiales dentro del universo de las emociones sociales. Están siempre.",
 @"(El amoroso). Personas indispensables en cualquier grupo, tienen 
sentido de la lealtad y de las consignas de conjunto. Jamás fallarán. 
Y son especiales para lograr cumplir los objetivos. ",
 @"(El juguetón). Divertidos y con buena onda, son quienes suelen animar 
las fiestas. O levantar el ánimo caído de un grupo. La sonrisa, el chiste, 
la cercanía con los otros son su ámbito de brillo.",
 @"(El arquitecto). Aunque a veces tienden a ser excesivamente dominantes, 
sus pares le reconocen su don de maestro. Y es que las personas Humano saben 
convertir el dolor y la pérdida en un sendero de aprendizaje y sabiduría. ",
 @"(El aventurero). Viajeros incansables, su propia vida es el contenido 
de su arte. Aventureros de nacimiento, buscan siempre abrir puertas, 
atravesar fronteras, desafiar y aprender. ",
 @"(El mago). Pragmáticos por excelencia, no pierden demasiado tiempo 
filosofando sobre el pasado y el futuro. Excelentes viviendo el aquí y 
ahora, son seres muy empáticos con facilidad para convertirse en líderes. ",
 @"(El visionario). Para nada prejuiciosos ni pacatos, buscan vivir 
con una gran apertura espiritual. Están siempre abiertos a lo nuevo, 
 a lo que no se inventó aún, a lo que no se pensó tal vez.
 Eso los convierte en seres confiables y buenos consejeros.",
 @"(El planificador). Cuestionadores permanentes, suelen sospechar
 de los conceptos dados por buenos en el mundo. Buscan la verdad, 
 y se niegan a las consignas obvias. Aman los desafíos.",
 @"(La tierra). Nacidos para las grandes causas del mundo, tienen 
un sentido natural para saber qué es lo mejor en el planeta.
 Y se comprometen en las luchas ambientales tanto como en las de igualdad.",
 @"(El reflector). Sus cualidades son difíciles de definir, pero es 
lo que los vuelve tan atractivos.Cierta conexión con los aspectos 
trascendentes de la vida. Parecen estar rodeados de un halo de misterio,
 como si fueran predestinados a indagarnos e indagarse.",
 @"(El transformador). Explosivos, extrovertidos, vitales, las personas Tormenta nunca pasan desapercibidos.Tienen una energía muy especial 
siempre en mayúscula, tendiente a ocasionar siempre adhesiones o rechazos, según sea su estado de ánimo.",
 @"(El iluminado). Espirituales al máximo, tienen un puente directo a 
todo lo sagrado del universo. Llenos de valores y principios, 
sobresalen en valores como la caridad, la compasión, el amor. 
Suelen comportarse de manera ejemplar. "
    };
    public static string[] Luz = new string[]
    {
 "Luz: Apoya y emprende nuevos comienzos.",
 "Luz: es honesto y se expresa auténticamente.",
 "Luz: usa la intuición y la imaginación para manifestar.",
 "Luz: florece en su mayor potencial con intención.",
 "Luz: se despoja de lo viejo para vivir con pasión y vitalidad. ",
 "Luz: une los mundos al entregarse a su verdadero camino.",
 "Luz: tiene un enfoque holístico hacia la salud y el bienestar. ",
 "Luz: usa la creatividad para compartir belleza e inspirar a otros.",
 "Luz: busca el bienestar y se permite simplemente Ser.",
 "Luz: vive una vida centrada en el corazón con compasión.",
 "Luz: tiene buen humor, fluye con alegría, le encanta divertirse. ",
 "Luz: usa su libre albedrío para elegir a consciencia y sabiamente.",
 "Luz: descubre nuevos espacios y disfruta las aventuras.",
 "Luz: confía en sí mismo para crear lo que quiere. ",
 "Luz: expande su mirada hasta captar la totalidad.",
 "Luz: establece metas claras y tiene la valentía para alcanzarlas.",
 "Luz: se siente uno con la naturaleza y posee raíces fuertes.",
 "Luz: usa el discernimiento para conservar lo que quiere.",
 "Luz: ve las transiciones como oportunidades para crecer.",
 "Luz: tiene claridad en su camino y brilla intensamente."
    };

    public static string[] sombra = new string[]
    {
 "Sombra: Cuida de los demás, pero no de sí mismo.",
 "Sombra: tiene dificultad para decir su propia verdad.",
 "Sombra: tiene dificultad para atraer una vida abundante.",
 "Sombra: se siente vulnerable y le falta paciencia y confianza.",
 "Sombra: tiende a ser excesivamente analítico y demasiado enérgico.",
 "Sombra: tiene dificultad para desapegarse, perdonar y cerrar ciclos.",
 "Sombra: se siente desequilibrado y le cuesta terminar sus proyectos.",
 "Sombra: tiende a ser idealista y perfeccionista.",
 "Sombra: estado de ánimo cambiante, suele anestesiar sus emociones.",
 "Sombra: Tiene dificultad para valorarse si mismo y tiende a mantener relaciones tóxicas.",
 "Sombra: se preocupa a menudo por todo y se toma las cosas demasiado en serio.",
 "Sombra: se siente víctima o no considera a los demás.",
 "Sombra: no puede explorar su interior y le pesa su 'mochila'.",
 "Sombra: experimenta inseguridades y baja autoestima.",
 "Sombra: se abruma y queda atrapado en los detalles.",
 "Sombra: queda atrapado en la duda y carece de flexibilidad.",
 "Sombra: tiene dificultad para estar presente y conectado.",
 "Sombra: vive en negación experimentando una realidad distorsionada.",
 "Sombra: teme el cambio y bloquea la transformación.",
 "Sombra: cede su autoridad y se desempodera."
    };
}
class ASCII
{
    public static string[] arte = new string[]
    {
@" 
         .:::::            ::^:.              
      .~7!~^^^^^~~!!!!7!!!~:..^!7~:.          
    ~JY!..!J55J5PPPPP5PPPP55Y?^ .~JY?:
  ^JP5^ ^5P55P5J?7!~~~~~~!?Y5P5J: .JPY.
 7P5PJ  YP55J~.             ^J5P5: 7P5Y^
!P5555^ !5P5.                 YPJ. !PYYY^
.JP5555Y^ .!Y7:.            ..!?~  !555555^
.55555555J!^.:^^.           :::.:!J55555557    
:55555555555Y?!~^^::::^::^^!7??Y55555555555^
^P5555555Y555P555555JJY5Y5555P55555555Y55Y57
:55Y5555555Y5555555J. ^P55555555555555J55YYJ.
^P5555555555555555P?  ^5555PP555555555555Y5!   
:555555Y555555YJJ55?  !P55?!!JPY55555555YY5^
.5555555555Y5Y. ~P5J. ~P5P~  !P555P55555YYY.
?P555555Y5555. ~P5J  ^P5P!  ?P5?7?Y55YYYYJ.
^55YYPY: !PP?. ^PP?  ^P5P~  ?PP^  ?5YYYYY~
 ~P555Y. !PP7  :5P?  ^P5P~  ?P5^ .J5YYJY~
 .YP55Y. !PP?  ^PP!  !P5P~  !P5:  ?YJJJ~
  :YPP?  !P5Y. ^PP!  7P5P^  !55~  7YJJ^
   .!57  ~PP7  ^PP~  !P55^  !5Y^  7?!^
     ..  ~Y57  ~PP~  !5Y5^  ~J?^  ..
            ...  .^!:  :!~^.   .
",


@"                                          
          .^^~!!7?YJ77?!!!!~^:.               
       ^?P#@@@@@@@@@@@@@@@@@&&BGJ~:.          
    :YB&@@@@@@@@@@@@@@@@@@@@@@@@@@#BP~        
  :?#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#!       
 :&@@@@@@@@@@@@@@@@&@@@@@@@@@@@@@&&&&&&?      
:B@@@@@@@@@@@@#&@@@@@@@@@@@@&B&@@&#&@&&@J     
~&@@@@&@@@@@G~.5@@@&@@@@@@@B: ?@@@@@@@&&&?    
J@@@@@@@@@B~  ^#@@@@@@@@@@@P   Y@@@@@@@&&G.   
5@@@@&#5?~. .Y&@@@@@@@@@@@@@!. .!P&@@@@&&@J   
P@@@5.   .!J.^JB#&@@@@@@@@@&G:    :7YP#@&#B:  
Y&#@&PPPG#@@G~...:!JY5YJ?!^^^?BG57^::~P@&#G^  
P@@@@@@@@@@@@@&B^.~^:  :~ .G@@@@@@@&&@@&#&P.  
P@@@@@@@@@@@@@@B.~@@&~ B#. 5@@@@@@@@@@&&#&?   
?@@#&@@@@@@&@@@Y .G@G !&B. Y@@@@@@@&&&&#BB7   
^&@&#@@@@@@&@@@B. Y@J P@5  5@@@@@&&&&###BB~   
 Y@@@@@@@@@@@@@B. 7@J:B@^ :B@@@@@@&&##BBBY    
 .B@@@@@@@@@@@@@5. 5@&&?  ?@@@@@&&&#BBBBY.    
  7@@@@@@@@@@@@@@#Y~77^^75@@@&&####BGGBY.     
   ?&@@@@@@@@@@@@@@@###@@@&&&##BBBBG5B7       
    :Y#@@@@@&@@@@&&&&&&&&####BBBBGGPJ7        
      .~J5PGG###&&&&&####BBPGGYJ7~:.          
            ...::^~7!7777~^:.:.                
         
",


@"                                              
          .:^^~^:^:.   .::.::..               
       :7JPPGGGGGGGG^  JGPPPPP5Y?^..          
    .?5GGGGPPPPPPPGG:  ?GPPPPGGGGGP5Y^        
  .!5GGPPPPPPPPPPPG5.  7BPPPPPPPPPGGG5~.      
 !PGGGGGPPPPPPPPPPG5.  !GPPPPPPPPPGGGGG5~     
.^^^^~!YPGGPPPPPPPG?   :PGPPPPPPGGPJ~^^^^:    
^GP55J!:.!PGPPPPPPG! . .PGPPPGPG5~.:7Y55P5.   
!P55PGGGJ:.YGPPPPGG^ ^. YGPPPGGJ.:YGGG55YJ.   
.::::^^~77: 7GPPPGG: ?^ JGPPGG7 :77~^^:^:..   
JGPPP5Y5J~^..7GPPGJ .P! ^PPPG7..^!J5Y5PP55Y.  
?GPGGGGGGGGP55PPGG: 7BY  JGPPPPPGGGGGGPPPP5:  
JGPPPPPPPPPGGGPGP~ :PGG? ^GGPGGGPPPPPPPP5PJ.  
?GPPPPPPPPPPGPPJ: ~PGPPG7 :JGPPPPPPPPPPP5P!   
~GPPPPPPPPGGGY^ .?GGPPPPG?  ?GGGGPPPPPP555~ . 
^GGPPPGGGGPJ:  !PGPPPPPPPGY~ :75PGGGPPP555^ . 
 JGGGP5Y?~. :75GPPPPGGPPPPGG5?^:.:!7JYJJY7    
 :!~^:..:^?5PPGPPGGGPP5PGGPPPGGPJ7~::::..     
  :!!?5PPGGGGGGGG5!::..:~5GGGGPPPPP5YYJ!      
  .7PBPGG5JJ??JYJ.       .Y?!!!!7JYYYY^       
    :?PG!       .                 ^J!.        
      .~^.     :7~.      :7^     .:.          
            .     :^^.      .:.                                                                
",


@"                                               
          .^^~!~7?YJ7!?!~~~~^:.               
       ^?5B##################BGPY7:.          
    .YG#&#B##G###########B########BG5~        
  :7G&#####B#############G###########B!       
 .B&#######B#####&#BBBB############BB##J      
 7&B###########&P7!7:^7!!Y############B#?     
~##B##B########Y ?B#^ B#P^!###########BB#?    
?&############P 7&#&^ G#&G J&###B#P####BB#~   
J&#B#########&P 5&##^ G#&G J&##########BBBY   
5&#############!^P#&~.B#5^!#########B#BGBBP:  
J&######GB######Y!7?^:!!!5###BB#####B##BBBP^  
5&#B###########B##BGGBB#################BB?   
Y&###########B#########B###BB#B###BBBGGGGG?   
.~~::^~~~~~~~!~P&#####BB##B^::::^~:........   
:YYYJYJJ55Y5Y. ?&#G######&P :PGP5GPY5555Y5:   
 5&#########&~ .^5######BJ. ^########G5GGJ    
 :G##B#BB###&! :!..^!!!^..~.:G##BGBBGGPG7     
  7&B#######&7 .#BY7:  ~JPB:.G#BGGPGPPG?.     
  .JB#BB####&5 .G&#&J .P&&G.:GGBGGPPPY!       
    :JB#&####P .G##&J  P#BG:.YGPP5P57.        
      .~JY5GB5. 5#B#J  YBGP: JY?~::.          
                                                        ...  .^77~ .!~::  .                                                              
",


@"                                              
          .::^^^~!7!:  . .^:..                
       :!?Y55555PPP! ~YY ?P555~:7^..          
    .7Y5P555Y55Y5P7 ~PP~.~5PP5^ ?PY5~         
  .!YP55555555555P~ :7~^Y~:~^^7Y~~??:^:       
 :5P5555555P55P55P!  ~555P? !555P! 7Y5Y!.     
.YP55555P5J77!!J5P! :.75Y7.^:J555: ^Y5P5:     
^555555J!:^77^ .YP! ~?::.:?5?~^^^:J!.~7^^~    
!P5555~^7J?!!J~:5P? :555.?P55P! 7P55Y:.J5J.   
?P555~^Y7!?J7~~Y555: 7PJ !P555^ .YP5P~ 755!   
?P555:.^?J!:^?55555Y^ .^7::!!::?!:~77:7!.^:   
7P555?~!7?JY555555555J~~~~:..^~!!~...:^^::~:  
?P5555P5555555555555555555555YYYY55Y555YY5J.  
?P555555555555555555Y5555555555555555555Y5!   
!P555555555555555555555555555555555Y555YY5~   
:5555P5555555YYYJYY555555555JJ?JJYYYY55YJJ:   
 75?!~^^^:^^::...:...:!JP7::.  .....::~?Y7    
 .^^!?JYYYY555YYY5Y??!..^ !YJ.75Y5:~Y7~.~.    
 .Y55YYYYYJJJ????!^YPP7  !P?~~^??~^^?YY!      
  :~~~~~^^^^^:~!!7Y5555: :!J5P~ ~?YJ~:^       
   ^YPP55555555P5555557.: ^JJ?:.^??7:.        
    .^7JY555555555YJ?~:~JJ^.. :7^ .           
                                                             .:^^~~^^^:. .^~~^^:.  .                                                             
",


@"                                              
          .:^~!!7JYJ?!.  ^!~:..               
       ^?5#&@@@@@@@@@@:  G@@###P?~.           
    :YP#@@@@@&&@@@&@@&: .G@@@@@@@@#P5~        
  :7B@@&@@@@@@@@@@@@#&^  5@@@@@@@@@@@#~       
 :#@@@@@@@@@@@@@@@@@@@~  P@@@@@@@@@@@@#?      
.G@@@@@@@@@@@G^5@@@@@@!  P@@@@@&@&&@@&&@?     
^#@@@@@@@@@@@5 ^@&&@@@!  P@@@@@&@@@@@@&#@?    
J@@@@@@@@@@@P: 7@@@@@@?  P@@@@@&@@@@@@@&&G.   
5@@@@@@Y77!^ :5&@@@@@@7  P@@@@@@@@@@@@@&&&J   
P&&@@@&PJ?J5B&@@@@@@@@7  P@@@@@&@@@@&@@&&&B:  
Y@&@@@@&@@@@@@@@@@@@@@!  P@@@@@@@@@@@@@&&##~  
P@@@@@@@@@@@@@@@@&P?~~: .G@@@@@@@&@@@@@&#&P.  
P@@@@@@@@@@@@@@B?:^7YB7 ~&@@@@@@@@@@@&&&#&?   
?@@@@@@@@@@&@@5. Y@@@G .G@@@@@@@@@&@@&&&##7   
~&@@@@@@@@@&@G  G@&P! ~G@@@@@@&@@@@&&&##B#~   
 5@@@&&@@@@@@7 .?!::7G@@@@@@@@&@@@&&&##B#Y    
 .B@@@@@@@@@@!  ?YP&@@@@@@@@@@@@&&&##BB#Y.    
  7@@@@@@&@@@7  P@@@@@@@@&&@@@&&&###BGB5.     
   ?&@@@@@@@@?  J@@@@@@@@@@#&&&##BBBBB7       
    :Y#@@@@@@?  J@@@@@&&&&&&###BBBGPY7        
      .~J5PB#J  Y@&#&&&###BGGGPY7~:.          
            ...  :~?77??7~~:...                                                           
",


@"                                              
        .:^~!?????J~  7J7^  ...               
        :!77777??Y?.  JBB?  ?B? .?!:          
    .?J?7!7777777:    7GG?  ?BY .5BG~         
  :!5PGGPGGGGGP!. ~J. ?GGJ  7BP: YGG7 :~      
 :PGGPPPPPGGJ^  ^YGG: ?GGJ  !GG: JGP7 .5~     
.5GPPPPPPG5^  ~YGGGP: 7GGJ  !GP: !BG7  J5.    
^PGPPPPPG?. ~5GGPPGY  7GGY  ~BG: !BP7  7G!    
7GPPPPGP5. ^GGPPPPG5. !GGY  ~BG^ ~PB7  ^GY.   
JGPGPPPGY  7BPPPPPPP. 7GGY  ~GG^ .PB?  !PP7   
JGPPPPPGG: :GGPGPPGG: JGG5  ^PG! ^GGJ  7GP5.  
?GPPPPPPGJ. ^J5PPGGB! JGG5  ~GB? :PG5. 7P55:  
JG5PGPPPPG5!.  .:^^!^ ?GPP. :GB?  5BY  7P5J.  
JGPPPPPPPPGGPYJ?777777YGPGYJYPGP?7PG57755P!   
7GPGPPPPPPPPGGGGGGGGPGGPPPGGGPPPGGPPPPP555~   
:GGPPPPPGGGGGPPPPPPPPPPPP5GPPPPG5PPPP555J5^   
 ?GPGPGG5YYY5GGPPPPPPPPPPPPPPPPPPPPP55YY57    
  5P5G?: ^~~:^YGPPPPPPGPPPPPPPPPPP555YY57     
  !BG? .J?7YG! ?GPPPPGPPPPPPPPPP55Y5YYY7      
   7G7 ??  .P5  PGPPPPPPPPPPP5555YJYYY~       
    :7.:?JJYJ. 7GPPP5PPPP555YY5YYYJJ7~        
         .:. :JPP5PP555555YYYJ?7~:..          
                ...:^!~~!!~^::...                
                                                  
",


@"                                             
          .:^~!~7?YJ! .!!~~~^..               
       ^?5G###&##&&&!~^?&####BG5J^..          
    .YG#&##&######BG P? 5&#####&&&#B5~        
  :7G#J~^^~J#######!.BP ~#####&GYJJP#B^       
 .B&&J ~BG^ J&##&G^ 5&&7 7&##&Y.~J! ~BB7      
 7&#&P.:?7.:5&&B7 :P####! ~G#&! ?#G: G##7     
~B####B5JJP#&BJ. 7B#B####Y .G&B7::.:Y#BB#7    
?&######&&&G7..?G########&G7.^5##BB###BB#P.   
J&B##&#B57^.~YB&#########B#&P~ :7YG####BB#?   
5&#BG?^::~JG###############B##GY!: :~?5GBBG:  
!7^!7JPG########################&#G5J77!~:^.  
~~:^!7YG#&#############B########&#BGY?77~~~   
Y&#G57^.^!5#&B################B57^:^!?PGGB?   
!&###&#G?^ :75###B#####B##&G?~.:75B###BBPB!   
^######&&#G7. ~P&#######&G~ ^JG#&####BGGPG^   
 5&###G?!!~?PJ. ?####B##? .J#&BJ!~^!PBGPGJ    
 .G##B. 5#P.:#G^ ~#####~ 7####^ ?GJ..5GP?.    
  !&##?:?Y7.?#&#7 !###! Y&#B##!.^?! ~GP7      
   7#&&BYJYG&####! J&?.5&##BBBBPY?7JG5!       
    :JB#&&&#######:~#^?&BBBGGGGGGGPJ7.        
      .~JY5GGGGGG#J ~:GBGGPPP5YJ!^:           
                                                                ......^!. :?7~^::..                                                                
",


@"                                               
          .::^^^~!7!~~!~^^^^:..               
       :!?Y555PP55PPPPP555P55YYJ7^..          
    .7Y5555555555555555555555555555YJ^        
  .!YP5555555555555555555555555555Y5P5^       
 :5P55555555555YYYYJJJYYJJY555P555YY555~      
.YP5555555P5?~.           .::~7J5555555P!     
^555555555?:  :!??77???JJJJ?~   ^Y5555555~    
!P555555PJ  :J5P5PP555YPPP55PY~  JP555555J.   
7P555555P!  7P555?~....^!YP555Y: ~P5555555!   
?P5555555^ .5555~ .7YJYJ^.75555: .Y5555555Y.  
7P5555555: :55P7 .5P555PY. JP55: .5555555YY:  
?P5555555: ^P5P7 :5P55PP~  ?P5Y. ^55555555?.  
?P5555555: :5555^ .!?J?^ :?55P?  ~P55555Y5!   
!P5555555^  JP555?~::::^75P55PJ  7P5555YJ5~   
:5555555P~  ?P555PP5555P555555Y. !P555YYYY^   
 7P555YYP7  !P5555555555555Y5PY. :555YYJY7    
  Y55555P?  ^5555555555555555PY. :55YYJY7     
  ~P5Y55PJ  :555555555555555555: ^5YYJY7      
   !5P55PJ  !P55555YY5555555555^  7YJJ~       
    :7??7. :YP5Y555555Y555YYYYY?. .~!^        
          !JYY5Y5555555YYYYJJJ?7^.            
             ...:.:^!~~~~~^::...                                                             
",


@"                                              
          :^^~!!?JYJ77?YJJYYJ?!.              
      .^JG&@@@@@@@@@@@@@#5?7!??JJJ!           
    ^5#@@@@@@@@@@@@@@&5~^7YB&@@@&G7           
  ^J#@@@@@@@@@@@@@@#?^:Y&@@@@&P!.:?GBY.       
 ~&@@@@@@@@@@@@@@@P.^P@@@&@&Y:.7P&@@@&.:7     
^#@&@@@&@&@@@@@@@P.J@@@@@@P:.J#@@&@@@? Y&!    
7&@@P7~~!~7G@@@@@7.B&##BP7 7#@&&@@@@7 J@@7    
5@#!.JB#&BJ:7&@@@B!~!!!7  Y@@@@&@@G~.5@&@5    
G@5 ~J??!?J! J@@@@@&&&B^.P@@@@@@B7 !#@@&&&7   
#@B:~B&Y PB7 P@@@@@@@@! G@@@@@&J.^P@@@@&&&P   
G@@B!~J! !!!G@@@&@@@@&^.B@&#P?^!P@@@@@@&&&G:  
.#@@@@#GPPG#@@@@@@@@@@@#7^!~~?5#@@@@@@@@&&&Y   
.B@@@@@@@@@@@@@@@@@@@@@@@###&@@@@@@@@@@&&#&!   
5@@@@@@@@@@@@@@@@@@@@@@@@&&@@@@@@@@@@&&&#&~ . 
7@@&&##BB#BGPPPPP55PPGB#&@@@@@@@@@@@&&###B:.  
.!!~^^~~~~!!!!777????7!~~75&@@@@@@@&&##B#J .  
 .G##&@@@@@@@@@@@@@PG@@&BY~:J&@@@&&##BB#? ..  
  ?&#BB#GGGGGP5P5J~~G@@@@@@G:~&@&&##BBBJ  .   
   .~!!7777?JJJYYYB@@@@@&&@@B.7&##BBBB!       
    ^5&@@@@@@@@@@@@@@@@@&&&&&Y P#BGGY!        
      .!YPGB####&@&&&&&&&#BGBG::!^::          
           ....:~!?7???7~^:::.                
",

@"                                             
          .::^^.           :.                
       ^JPBBB#&!          .#BGPY^.           
    :PB##BBBBB#!          .BBBBB#BBG!        
  .JB#BBBBBBBB#^          .GBBBBBBBBB?:      
 ~PPGBB#BBBBBB#~          .BBBBBBB#BGG5~     
 ~:::..!PBBBBBB5JYY?JYYYY55BBBBBB5~..::^~    
~&###GY: .P#BBBBBBB#BBBBBBBGBB#5. ^5B####.   
:!~7?5PGP: ?#BBBBBBBBBBBBBBBB#! :PG5Y7!~^    
:^~!^::^:.  ~BBBBBBB##BBBBBBB^  .:^:^^!!^^   
Y&B##BB#G57~^5#BBG#Y~!PBBBB#5~~75B#B##BBBG.  
YBPBBBBBBBB##BBBBB7    7#BBBB###BBBBBBGGGP.  
5#BBBBGBBBBBBGBB#G     .BBBBBBBBBBBBBBGGB?   
!#BBBBBBBBBBBBBBBY     .#BBBBBBBBBBBBGGPB~   
^#BBBBBBBBBBBBBBBG     ^#BBBBBBBBBBGGGGPG^   
 GBBBBBBBBBBBBBBB#Y:  ~BBBBBBBBBGBGPPP5PY    
 ^#BBBBBBBBBGBBGBB##BB#BBBBBBBBBGGGGP55Y.    
  Y#BGBBBBBBBBBBBP!^:::~P#BBBBGGGGP555J.     
   YBBGB#G5YJY5G7        YP?7!7?YP55P!       
    ^5#B^                        .Y?.        
      .^.      .^        ::      ..          
               .:.       ..                  
",


@"
                                             
        .^~7??YPG5JYY??J^ ..             
     :JB&&&@@@@@@&&&@@&7^5&&#B~          
   ~&@@@@@@&&&&&&&&&@5 :&@@@#! .5!       
 ~#&@&&@B55#@&&&&&&B: 7@@&5: :P&&&?      
^&@&&&&~:J~ 7@&&&@#  J@@G. .P&@&&&&G     
Y@&&&@# ^BG .&&&&@Y .&@J  Y&@&&&&&&&G    
&&&&&&&Y^..^B@&&&@J Y&! .G@&&&&&&&&&&^   
.&&&&&&&@@&&@@&&&&@7 BJ  G@&&&&&&&&&&&B.  
.&&&&&&&&&&&&&&&&&@Y G^ ?@&&&&&&&&&&&#&^  
.&@@&&&&&&@&&&&&&&&&.~ J@&&&&&&&&&&&###^  
.5YG&@&&@&G&&&&&&&&@Y ^@&&&&&&&&&&&&B#B   
~:..!PGJ. #@&@@&&&&@J#@&&&&&&&&#&&&##5   
B@&G?~:.~B@&@55@&&&&@&&&&&&&&&&&&&#B#J   
^P?JP#&@@@@&? Y@&&&&&&&&&&&&&&&&&#BBP.   
 .^:. .::^:  !&&&&&&&&&&&&&&&&&##BB5.    
  G@&BPJ!7?P&@&&&&&&&&&&&&&&###BBG?.     
   Y&@@@@@@@&&&&&&#&&&&&&####BBGP!       
     ~Y#&&&&&&&&&&&&&&&###BG5~:.         
         ..:::!7Y?JJ?7~:^:.              
                                             
",


@"                                         
         .^~:  7?!!!!~~. ..              
     .!~ JGB!  PPPGGGGG~ JGG!  :.        
   :5GG7 7GG7  YGPPPPPG~ 7GG?  JG~       
 ^5GPPG! ^PG?  7GPPPP5G7 7GG?  ^GP~      
:PGPPPG! :PG?  7GPPPPPG! ~GGY  ^GPGJ     
7GPPPPG7 :GG7  !GPP5PPG? :PP5  .PPPP?    
5GPPPPG? ^GGY  !G5PPPPGY  5PG. .PPPPP:   
.PPPPPPPJ ~GGJ  ^GPPPPPP5  PPG: .GPPP5Y   
.PPPPPPPY :GG5  :GPPP5P5P  PGG~ .PPP5YP.  
PPPPPPG? .PP5  .GPPPPPPG. ~77.  5PP555:  
5PPPPPG5. ..:. ~GPPPPPPG~::^~~!7PP5YY?   
5GGGPP5PP555555PPGPPG5PGGGGGGGGGGPP557   
.:.:.            .. ....:::^:::::^::^:   
 !~^~~~~~!^^^^~^^^:^^:..:::..:::.....    
 ^GGPGGP~~::::.^5GGGGGG5!!!~~!77YYJ?.    
  7GPPGP  :~~~  YGPPPPGJ  .::.  JJ~      
   ~YGPP. ^GGP  ?PPPPPP7  ^P5~  !~       
      :!Y. :GPY  ?P5555Y?  .??.           
                                        ..   :^!~~^..                                                    
",


@"                                         
        ...  .       .^:.                
     ^Y5~!5B#7 ?#&&BJ.J@@&G.:J7^.        
   ~&@@ :@@@@  B@@@@@^ @@@@^ P@@@?       
 !&@@@@7.~YG#P: .^~: .YPY!.^P@@@@@Y      
~@@@@@@@@BY?777!~   ^?YJ5B&@@@@@@@@B     
P@@@@@@@@@@@@@@@B   G@@@@@@@@@@@@@@@B    
&@@@@@@@@@@@@@@@^ 7..&@@@@@@@@@@@@@@@~   
.@@@@@@@@@@@@@@@B  &! !@@@@@@@@@@@@@&@&.  
.@G ^@@@@@@P J@@: 7@&. Y@@~ Y@@@@@@:.&@~  
.@@P..JGBG7.J@@B  &@@&. ?@@? ^JGPJ:^#@@~  
:@@@@B?^~?5&@@P. #@@@@&: :&@@P?!7Y#@@@#   
&@@@@@@@@@@@5  G@@@@@@@Y  ?@@@@@@@@@@P   
P@@@@@@@@@&~ .#@@@@@@@@@@Y. !P&@@@@@@J   
.@@@@@@#5~  ?&PB@@@@@@@PG@@#J~.:!7JJY.   
 .~^^.  .~G@@@: ?@@@@@J ?@@@@@&#57Y7     
  ~5PG#&@@@@@@@P..^!~:^B@@@&@@&&&&G:     
   J@@@@@@@@@@@@@&BG#&@@@@@&&&&&#Y       
     ~5&@@&@@@@@@@@@@@@@&&&#GY~^.        
                                        .:::^!J5J5YY?!~^^..                                                    
",


@"
         :~~!!?JY?7?7!!!~^..             
     :7PB##B###BBB###BB##BBBG?^:.        
   ^G##BBGBGBBBBBBBBBBGBBBBBBBBBB~       
 ^PBBGBBBGGBBBBBBBBBBBBBBBBBBBBBGB!      
 :::::.  ..   .::..!::::5#BBBBBBGGBJ     
7#GBB7.~55.    .55!:?GGGBBBBBBBBBGGGJ    
GBB#P ~&&^      J&#..#BBBBBBBBBBBBGGG:   
.BBBBB^ ~Y?     :5J^:PBBBBBBBBBBBGBGGGP   
.BBBBBB57^~^:::^~~75BBBBBBBBBB#BBBBGGPG:  
P#BBBBB##BBBBB#BBBBBBBBBBBB#!.5#Y:7BPP:  
.GBGBBBBBBBBBBBBBBBBBBBBBBBBB: ?&7 ~BPY   
...:::........::.!#BBBBBBBBB. ?&! ^GP?   
!BY~:.:~!7?JYYYYY5BBBBBB#BBB  7&7 :PP!   
.:.!5BB##BBBBBBBB#5.^B#?^Y#G  7#! :PJ    
 .##BBBBBBBBBB#BB#5  B#^ 7#P  7B~ ^5     
  Y#BBBBBBBB#P^~B#Y .B#: 7BP  7G~ ^.     
   ~G#BBBBBB#J  B#J .BB. !G5  YP^        
     ^?5PGBBBJ .B#? .GG. ?5J  :.         
                .....  7!: .~:  .               
                                             
",


@"                                     
        .^!!J^  P?  J7  !~:.             
     ^JB&@&@@B .@& .@@..&@@&B5!^.        
   ~#@@&&&&@@P .@&  &&. &@@@@@@@&7       
 ~#@&&&&&@&P5!  ::  ..  :~7P&@&&&&?      
~@@@@@@@#~  .~?J?777?P5B57~. 7&@&&@G     
.?7~~~~7. :G@&5^:^~~!^:~P@@&! .!~~~~.    
JYYJYYY: .&@G  ?#&@@@&#^ ^&@&: ^YYJJY.   
^~!~!!!  ~@B  B@&&&7!&@@^ 5@@P  .::^^^   
.B#####&^ J@G  &@@@@~ :@@P ^@&&: ~!!!!!.  
::::::^. Y@&5..!YJ?. J@@! .&&@: ~!!!!!.  
.PGGPPPG! !@&@&BJ!!!J#@&~  Y@&@^ J@&&&B   
&@@&&@@P ~@&&&&@@@@@#?   P@&&@^ :&&##P   
5@&&&&@5 !@&&&&&@&B!   ?#&&&&@~ ^&###J   
.&&&&&@7 7@&&&&#J:  ^Y&&&&&&&@^ 7&BBP.   
 !@&&&@~ J@&&&5:   !G&@@@&&&&&. ?#GG.    
  G@&&@~ J@&&&&@&BY^  .~Y#&###. :#J.     
   7&@B  B&&&&&#PJ~::^?5G##BB#: .J       
     : .P&&&&&G?~. .^?PB#BBG57:          
                .::::!?Y7.   ..::.                                                    
",


@"                                       
         :^^~~!?J7!!!~~~^:..             
     .~J5GGGPPPPPGGGPPPGPPP55Y?~:        
   ..^^^^^::^:^^^:.::^^::!^:::^^!.       
 :5PGGPP5?J??7JPP5555PPPPPYYY555PP7      
:PGP?~:::^::.   ~PPPPPGY~.....^!5P5J     
7P5: .?55YPGG?.  .PP5G!  ?5555?^ ^PP?    
5G.  5GPY: .!PP~  ~GG7 ^PGPPPPPP~ ^GP:   
.PG. .PGPGG^  5PY  .PG: JG5PPPPPGY .GPY   
.PGP. .~77^  !GG^  ?GPJ .YPGGGGG5. ^G5P:  
.PPPPJ^..:^75G5:  ^5PPPJ:..:~~^:..?PP55:  
.PPPPGPPGGGP7:  :YGPP55PPPJ7!77?YP5555J   
PPPPPPPP~.  :75PPPPPPP5PGY~::::?GPYY5?   
7GPPPPPPJ!:..:!J5PPPPPGY:.::^JGP555YY!   
.5PPPPPYJ?!.  .^75PPG5J?77!7JPP55YYY?.   
 ~GPPGY~.   .~JPGPPPY~.:.:^JPP55YYY?.    
  JGPPPP5?:   .!PPP7:::.:YG5JYYY?J7      
   ~5GGY^.  :?5PPP~^~^~5P5YYYYYJJ!       
     :7Y555~  :55^^~~J55YYYJ7~:.         
                                                  .  .:~!~!!!^::...                                                          
",


@"                                      
        .^77JJ5GBP55BBBBG5?~.            
    .^5&@@@@@@@@@@@@@@@@@@@@@&GJ!.       
   .YGB@@@@@@@@@@@@@@@@@@@@@@@BGP?       
 ~J??~ Y@@@@@@@@@@@@@@@@@@@@@& .77J?     
~@@@@B 5@@@@@@@@@@@@@@@@@@@@&& !@@@@?    
P@@@@B .:.:.?@@@@@@@@@@@B....: 7@@@@@7   
.@@@@@@@&&@& :@@@@@@@@@@@Y 5@@@@@@@@@@&.  
^@@@@@@@@@@@. ^^^~&@@7^^^. G@@@@@@@@@@@7  
^@@@@@@@@@@@@&#&^ B@&. #&&@@@@@@@@@@@@@~  
^@@@@@@@@@@@@@@@! ... .@@@@@@@@@@@@@@@@:  
~@@@@@@@@@@@@@@@? P@&..@@@@@@@@@@@@@@@#   
.@@@@@@@@@@@!:^^. #@@: ^^::&@@@@@@@@&@B   
B@@@@@@@@@@. G&&&@@@@&&&: B@@@@@@@@&&5   
?@@@@@P5555  &@@@@@@@@@@~ !555Y#@&&&#.   
 B@@@& .JJJJ5@@@@@@@@@@@BYYJY! 7@&&B.    
 :J77~ 7@@@@@@@@@@@@@@@@@@@@@B .!~!.     
   ^5PP#@@@@@@@@@@@@@@@@@&&&&#YJ?7.      
    ~G@@@@@@@@@@@@@@@@@&&&&#B5?!.        
            .^~?JJJY5GG5YY?!~:^:.             
",


@"                                         
         :~~!!?JYJ7?7!!!~^..             
     :7GB#########B########BBJ~:.        
   ^B#PY?777!77!!!!7!!!~^^^~7JG#B~       
 ^GB7. .. ^~~^.~77!.  ^!!!~~^. :5#!      
 P#: :!PPGY^:.~5Y?5PP..B##BB#BJ  ?#Y     
7#B  #PY5G7    75JY5P^ 7#BBBBG#7 .BB?    
GB#J ^YPGGB577YBBBG5^ .PBBBBBBBP  PBG:   
.BBBBG?^^:::.:::...::~YBBBBBBBBBP  PBGP   
.BBBBBBBBBGGGGGGGGGBB#BBBBBBBBBBP  PBGG:  
.BBBBBBBBBBBBBBBBBBGBBBBBBBBBGB#Y  5BPG:  
.BBBBBBBBBBBBBBBBBBBBBBBBBBBBBB#?  PGGY   
5#BBBBBBBBBBBBBBBGBBBBBBBBBBBBB?  5GPJ   
J#BBBBBBBBBBBBBBBBBBBBBBBBBBBB#~  5PP!   
.#BGBBPPBBBBBBBBBBBBBBBBBBBBBBB.  5PY.   
 ~##5   .PBBBBBBBBBB#BB#BBBBBG:  !PY.    
  5&P.  .P#7?JJJJ?J?!J??7!~^.  .7P?      
   !B#BGB#B:..    .. .  ...:^!?5Y^       
     ^JPGGBBBBBGGGGGGGG5PP55J!~:         
                                                    ....:^77777~:...                                                        
",


@"                                            
        .^!^7?YPG?  !?777~:.             
     :JB&@@@@@@@&G  P@@@@@&&#5^^.        
   ~#@@&&&&&&&&&@P  5@&&&#&&&@@@&?       
 ~#@&&&@@&&@@&&&@5  B@&&&@@&&@@&&&Y      
 B@&&&&B~^~^?&&&@?  ?@&&&J^^^~G&#&&G     
Y@&&&&&. G&7 P@&@J  J@&@J ~&# .@&&&&G    
#@&&&&&G~:^~Y&&&@G  Y@&&&Y^^^~G@&&&&&^   
&&&&&&&@@&&&@&&&@G  Y@&&&@&&&@&&&&&&&#.  
&&&&&&&&&&&&&&&&@B  7@&&&&&&&&&&&&&&#&~  
&&&&&&&&&&&&&&&&@P  ?@&&#&&&&&&&&&&&##^  
&&&&&&&&&&&&&&&&@B  P@&&&&&&&&&&&&&&#G   
B@&&&&&&&&&&&&&&@B  Y@&&&&&&&&&&&&&##5   
5@&&&&&&&&&&&&&&@#  G@&&&&&&&&&&&&#BB?   
:&&&&&&&&&&&&&&@&B  5&@&&&&&&&&&##BBP    
 !@&&&&&&&&&&&#! .::..7#@&&&&&&#BBB5     
  G&&&&&&&&&@&  J#&@&B. G&&&###GBB?      
   7&@@&&&&&@Y ^@@&&&@7 ~&BBBGGP5^       
     ~JB##&&&#~ ?B#BG7 .P#GGY~^.         
          ::::^:      .^:..             
"
    };

    internal static string[] intro = { @"
 _____                                                                                             _____ 
( ___ )-------------------------------------------------------------------------------------------( ___ )
 |   |                                                                                             |   | 
 |   |  _   _                                             _  ___         __  __                    |   | 
 |   | | | | | ___  _ __ ___  ___  ___ ___  _ __   ___   | |/ (_)_ __   |  \/  | __ _ _   _  __ _  |   | 
 |   | | |_| |/ _ \| '__/ _ \/ __|/ __/ _ \| '_ \ / _ \  | ' /| | '_ \  | |\/| |/ _` | | | |/ _` | |   | 
 |   | |  _  | (_) | | | (_) \__ \ (_| (_) | |_) | (_) | | . \| | | | | | |  | | (_| | |_| | (_| | |   | 
 |   | |_| |_|\___/|_|  \___/|___/\___\___/| .__/ \___/  |_|\_\_|_| |_| |_|  |_|\__,_|\__, |\__,_| |   | 
 |   |                                     |_|                                        |___/        |   | 
 |___|                                                                                             |___| 
(_____)-------------------------------------------------------------------------------------------(_____)
 " };

    internal static string[] piramide =
    {
 @"
 
 &%%%%%%%% 
 &/@,& &@& 
 &&&&&&&&&&& 
 &&&,&&&&&&@#&&& 
 #&&&&&* &&&&&* &&&&&, 
 &&&&&&&&&,,,,,, #&&&&&&&& 
 &&&&&&&&&&&.......&&&&&&&&&&& 
 &&&&&&&&&&&&%@#######&&&&&&&&&&&&&/ 
 &&&&&&&&&&&&&& /&&&&&&&&*&&&&&&&&&&&&&& 
 &&&&&&&&&&&&&&&&( &&&&&&&.,&&&&&&&&&&&&&&&& 
 @&&&&&&&&&&&&&&&&&&&%&&&&&&&/&&&&&&&&&&&&&&&&&&&# 
 &&&&&&&&&&& 
 "
 };

    internal static string[] pedidoDatos =
    {
 @"
  ___                                        __        _              _                    _       _         _       
 |_ _|_ _  __ _ _ _ ___ ___ ___   ____  _   / _|___ __| |_  __ _   __| |___   _ _  __ _ __(_)_ __ (_)___ _ _| |_ ___ 
  | || ' \/ _` | '_/ -_|_-</ -_) (_-< || | |  _/ -_) _| ' \/ _` | / _` / -_) | ' \/ _` / _| | '  \| / -_) ' \  _/ _ \
 |___|_||_\__, |_| \___/__/\___| /__/\_,_| |_| \___\__|_||_\__,_| \__,_\___| |_||_\__,_\__|_|_|_|_|_\___|_||_\__\___/
          |___/                                                                                                      
 "
 };
}

class GraficoMenu
{
    protected static int origRow;
    protected static int origCol;
    protected static bool salir = true;
    public static void WindowDimension()
    {
        Console.BufferHeight = Console.WindowHeight = 37;
        Console.BufferWidth = Console.WindowWidth = 130;
    }

    protected static void WriteAt(string s, int x, int y)
    {
        try
        {
            Console.SetCursorPosition(origCol + x, origRow + y);
            Console.Write(s);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
        }
    }

    public static void WriteCentered(string text, int row)
    {
        string[] lines = text.Split('\n');
        // if si line .length supera 130 cambiar de linea
        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].Length < 128)
            {
                string line = lines[i];
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, row++);
                Console.WriteLine(line);
            }
            else
            {
                text.Split('\n');
            }
        }
    }

    public static void WriteCursorPosition(string s, int y)
    {
        int x = (Console.WindowWidth - s.Length) / 2;
        if (x < 0) x = 0;
        WriteAt(s.Substring(0, Math.Min(s.Length, Console.WindowWidth)), x, y);
    }

    internal static void InterfazMenu()
    {
        bool salir = true;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        origRow = Console.CursorTop;
        origCol = Console.CursorLeft;
        DibujaMarco();

        int startY = 1;
        foreach (string line in ASCII.intro)
        {
            WriteCentered(line, startY);
            startY++;
        }
        WriteCentered("", 1);
        int startW = 15;
        foreach (string line in ASCII.piramide)
        {
            WriteCentered(line, startW);
            startW++;
        }
        WriteCentered("Ingrese un espacio para iniciar", 14);
        WriteCentered("Presione S para cerrar el programa.", 15);
        WriteCentered("Desarrollado por Carlos Bello, Guido Gavilan, Jorge Casco, Walter Benitez, Francisco Garcia:", 31);
        WriteCentered("5º Año 8va Division Junio 2024", 32);
        WriteCentered("Escuela Tecnica Nº12 Libertador General José de San Martín", 33);
        WriteCentered("©Copyrigth 2024 - Todos los derechos reservados", 34);
        ConsoleKeyInfo teclaLeida = Console.ReadKey(true);

        switch (teclaLeida.Key)
        {
            case ConsoleKey.S:
                salir = false;
                break;
            default:
                Program.Imprimir();
                break;
        }
    }

    internal static void DibujaMarco()
    {
        int height = Console.WindowHeight - 1;
        int width = Console.WindowWidth - 1;
        WriteAt("╔", 0, 0);
        WriteAt("╚", 0, height);
        WriteAt("╗", width, 0);
        WriteAt("╝", width, height);
        for (int i = 1; i < width; i++)
        {
            WriteAt("═", i, 0);
            WriteAt("═", i, height);
        }

        for (int i = 1; i < height; i++)
        {
            WriteAt("║", 0, i);
            WriteAt("║", width, i);
        }
    }

    private static string[] WrapTextArray(string[] array)
    {
        List<string> wrappedList = new List<string>();
        foreach (var item in array)
        {
            wrappedList.Add(WrapText(item, 120));
        }
        return wrappedList.ToArray();
    }

    public static string WrapText(string text, int maxLineLength)
    {
        var words = text.Split(' ');
        var wrappedText = "";
        var lineLength = 0;

        foreach (var word in words)
        {
            if (lineLength + word.Length + 1 > maxLineLength)
            {
                wrappedText = wrappedText.TrimEnd() + Environment.NewLine;
                lineLength = 0;
            }

            wrappedText += word + " ";
            lineLength += word.Length + 1;
        }

        return wrappedText.TrimEnd();
    }
}

class Horoscopo
{
    internal static int valorMes(Usuario user)
    {
        int[] valores = new int[] { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };

        return valores[user.Fecha.Month - 1];
    }

    internal static int CalcularKin(Usuario user)
    {
        int x = CalcularValor(user.Fecha.Year) + valorMes(user) + user.Fecha.Day;

        if (x > 260)
            return x - 260;
        else
            return x;
    }

    internal static string CalcularPropiedadKin(Usuario user, Datos datos, int var, bool tipo)
    {
        int n = CalcularKin(user);
        int x = n - var * (n / var);
        int e = 12;

        if (tipo)
            e = 19;

        if (x == 0)
            return datos.Nombres[e];
        else
            return datos.Nombres[x - 1];
    }

    internal static int CalcularValor(int ValorAnio)
    {
        int anios = 1910;
        int valor = 62;

        for (int i = anios; i < ValorAnio; i++)
        {
            valor += 105;
            if (valor > 260)
                valor -= 260;
        }
        return valor;
    }
}

class Program
{
    internal static void PedirDatos(Usuario user)
    {
        bool error = false;
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        GraficoMenu.DibujaMarco();
        GraficoMenu.WriteCentered("Desarrollado por Carlos Bello, Guido Gavilan, Jorge Casco, Walter Benitez, Francisco Garcia", 31);
        GraficoMenu.WriteCentered("5º Año 8va Division Junio 2024", 32);
        GraficoMenu.WriteCentered("Escuela Tecnica Nº12 Libertador General José de San Martín", 33);
        int startY = 1;
        foreach (string line in ASCII.intro)
        {
            GraficoMenu.WriteCentered(line, startY);
            startY++;
        }
        int startA = 13;
        foreach (string line in ASCII.pedidoDatos)
        {
            GraficoMenu.WriteCentered(line, startA);
            startA++;
        }

        GraficoMenu.WriteCursorPosition("Ingrese su nombre:", 20);
        user.Nombre = Console.ReadLine();
        do
        {
            try
            {
                GraficoMenu.WriteCursorPosition("Ingrese su fecha de nacimiento (dd/MM/AAAA): ", 22);
                string input = Console.ReadLine();
                user.Fecha = DateTime.ParseExact(input, "dd/MM/yyyy", null);
                error = false;
            }
            catch (System.FormatException)
            {
                error = true;
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                GraficoMenu.WriteCursorPosition("Fecha no válida, intente nuevamente.", 24);
            }
        } while (error);
    }

    internal static void MostrarValores(string nombre, DateTime fecha, string tono, string sello, Datos sellos)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        GraficoMenu.DibujaMarco();
        string fechastr = $"{fecha.Day}/{fecha.Month}/{fecha.Year}";
        GraficoMenu.WriteCursorPosition($"{nombre}, según tu fecha {fechastr} tu Kin Maya es {sello} {tono}", 2);

        for (int i = 0; i < sellos.Nombres.Length; i++)
        {
            if (sello == sellos.Nombres[i])
            {
                GraficoMenu.WriteCentered(Descripcion.descripcion[i], 4);
                GraficoMenu.WriteCentered(Descripcion.Luz[i], 8);
                GraficoMenu.WriteCentered(Descripcion.sombra[i], 9);
                GraficoMenu.WriteCentered(ASCII.arte[i], 10);
                break;
            }
        }

        GraficoMenu.WriteCentered("Presione Enter para volver al menú principal.", 33);
        ConsoleKeyInfo teclaLeida = Console.ReadKey(true);
        if (teclaLeida.Key == ConsoleKey.Enter)
        {
            GraficoMenu.InterfazMenu();
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            GraficoMenu.WriteCentered("Error de marcación, presione alguna tecla para reiniciar el programa.", 33);
            GraficoMenu.InterfazMenu();
            Console.ReadKey(true);
        }
    }

    internal static void Imprimir()
    {
        Usuario user1 = new Usuario();
        PedirDatos(user1);

        Datos Tonos = new Datos
        {
            Nombres = new string[]
        {
 "Magnético", "Lunar", "Eléctrico", "Auto existente", "Armónico",
 "Rítmico", "Resonante", "Galáctico", "Solar", "Planetario",
 "Espectral", "Cristal", "Cósmico"
        }
        };

        Datos Sellos = new Datos
        {
            Nombres = new string[]
        {
 "Dragón Rojo", "Viento Blanco", "Noche Azul", "Semilla Amarillo", "Serpiente Roja",
 "Enlazador De Mundos Blanco", "Mano Azul", "Estrella Amarillo", "Luna Roja", "Perro Blanco",
 "Mono Azul", "Humano Amarillo", "Caminante Del Cielo Rojo", "Mago Blanco", "Águila Azul",
 "Guerrero Amarillo", "Tierra Roja", "Espejo Blanco", "Tormenta Azul", "Sol Amarillo"
        }
        };

        string tono = Horoscopo.CalcularPropiedadKin(user1, Tonos, 13, false);
        string sello = Horoscopo.CalcularPropiedadKin(user1, Sellos, 20, true);

        MostrarValores(user1.Nombre, user1.Fecha, tono, sello, Sellos);
    }

    public static void Main()
    {
        GraficoMenu.WindowDimension();
        GraficoMenu.InterfazMenu();
    }
}
