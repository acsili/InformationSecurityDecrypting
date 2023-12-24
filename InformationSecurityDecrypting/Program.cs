﻿using System.Text;

var str = "AHMONFHCJHKFBAAPCHGLKIGJEKCFHIHAODAFAEEMGMAIBANHAPGEFJJAJAAAENAIFJCIMOACEOHNICGBMDANDJHFFAAHNPENACCCEHIMIDHOHBAEECLBCAAMANJNDHOFCFFMAGPBKNEDCAINNNLLJAAGIAMAHKGMNKGIOIMOCKMJAOOFHEAFAFFMLHPHLAFFAFMEDFEKEHLMNPAKCOCIMAALMNFAKCHHAAHEMINKFOHBPEJKMHAIAAELNALMPACNDBBANJHADAMDIADBMAMPEFOBGHEOIOENKMMFNDCCBDLMJOICHEPBAPICCDDKHAHCOONGPAAGLNBNOCNPNCMLDAHMNADCCHAFJBAMLADEMACCADPENFJEHHDBICKDPFAKIPPDMCNEEMNOPEEKJAGHOAOPLABNBOPDAAHENOGCFNLFDAJHOPJKHPIDDJCKFFOPCNANNHAKADOABAHCAHIAJDILJDPOMPADMMNCAHEPPCOMEJEPNGAADAAJNAPNNPAKAHIDNJPHEBPBKGADJOPBAAGNBNNNPAKCNFHBOIGBNKLFBOOOEEBBNAFCPAJHHAJPKMKKFKCLFKPKOGIDHEOCAAMFIAJFEAFBKEHCFGHFCFOIPGILMJAPBAAEMAKACNEEAGNGMNNEBFBOEEJOKHPFCHAPDCBAGCIJCEJOOICOCKBMCIHKFCGINNFMLFJHCAGDOMDGAPANCDEAPLILODAOPGIAENPOBCODAKAFJFAOLHGAFKAHMMFEKHEGPCHMKCEBFCBKAAOKINJOBAGOOGMGNCJADMPAFOILAKFJFHGECHNFEMAKOGMGKFHDLHMCPINAOHKFAPIKCDPONJOMFHIKMAICAAMOLCNBADNONKJIIBCACAAFHPMGGAAGEJNJPEPIDPGENAAPDAFAKOHAHBOOAIIELKEOBAHHEHFJKPNAHDJOOIOANOODAAIHMABOMAOCNNCJMEHBMMGCMEOCHEDOADGOFLDNCAPHOENIANBCAOPEKAOCAFMICAAOHNJNKHJPNABCAHBBMCFEOAAGEGDOOAHOMANDDIBECDOENFAMFHPFNAKNOJCGFPANBDPNIGICDAPHAIAPOKFNJAHFAEHJFDCAFDOMHGAPFEAOOIHAFKICAOACOKFLKIHMILIHAINBAKBCDIEMPKNMBHJAFDNFFPCPEJCMCGNCJGKCFAAHEAPAJBAGAELDKJGDFAGFKIJDAKKAACGFAMANJAHNEOAJMJHPOABHBEOJOPKGAEIBFMCKDANEFDHEMFEALHLIBCGPNBNOHPIPBDJKKFACPIJEADAMFLDNCAONDPBAAFBJIHFEAADGOCFKCEADNMLNNHNNNBPCMAELMNIIDCOEFAPKAABKNNJEAAGCKMKDNFJDLHJAOOIGAKKDEAACJNNNLBAIOADMDBHCCEDCLHIHMIMLDJAGMAHAJDEPNKMBCPENADIMNHAFBMBDAGABNNENBAMANLFKHAALMAIAOLGGDAGFKNHHOOBNFIDPKBGGAFAFHHDNGJIBANKDNKABKOINLGAHAAKPNOJDHOEAJAAJCFHIFECFMMCMDGHEDEFEOAHJPNODOIPBAAHHFJCAOAPMMNANMHAHAEAFOMLNJACCCAFKMAFNJABHNEHFHAKOAHIMDCEOHAHEHDOHOIIACOFKENFFDKDFOAJHBNAALOPAALPCFJCLPAIMPNAGHNMMAAAGKJANHAPNDAJCNGAFPNAAPOHHMLHOBJAAMADAHDCFAPGFMJIDKAHKEEABKOBEKAECNAKMEKIFFKKMKFHBNHLHFIAPOIBDDPIBLDMKGPIJCIKMABIBDFJKFADBABJGIFDHNHBLCEAGOJCCFOIFHOMKFANHKFPOAEOBGIHEJJINCFMONHAMPDJAKAHPAEJBODIFJDBOMIADMBLJAHEFICIMJJELNFHADAAKCACNMPAKAPICNLMFDHDBBGAHDOFJAOGFPONNPAJGACOAMONFMNEOPEJJCINIABILGFHKKADCAKIMEFAKBHAAKBJIEIOCCAAHOAONCHBEHKEEKECJLMMMOIFKOFLNEGHOBFECAOIEABHGAKNGFBGFNAGPAMIOCCGEEMBAGDAIKKLHDPAMADCNMHIKKHDFFDEHJLMMAGIPDFEAFEFJHMNHOMPFMPLMAFGINHAFGALFMNJGOCACDMFAENEPFDDDFABAJAHEHGNDFHOGCDCNKCBFNDBKMBEFAGOEFFBPFACDAHPENJHBLADCPAJKAAHOMHIJDDOKCEAMFDPFMIEMHKJMACGADGKDOBAELEBADNPKKHLLNJAMEADAMOICKFJDCPGEADIFHHIFKIJJAENABIBFEJICCBBICAAGONKACCHBECHEFAADNAFFCMJEAKNEKCJGGMIAAIAGOPEDIIIMLFLKIENMCNFGMAGGHNHFPHHAKAAAAIAFOKGFDAKJELOBFEPFHMIDJNOCKEJCAEJHMMJEMACFFPFPAAHDDNJDHAAAHGMHOAAPDNEAENFBMCHGHHAGOCDAJHEMCNDHFAFJBAHHEMKBEGOCAANFLABOAJBGMFJINGJCOFHAPACJDJMAHEOLOMOOEHPOEIDBOEJBCCEAHIBMFGJOAGGEFFBNEAJCMDEAAGIFCFJKOACMKMBBDAAINAHNIPIANHDBMIHGDKHCMEOHKMCLOHHDMDHCKNIHDMCJOBAFJEOAKNPDFIEACDABOLJAIDBNHJNGAIEDJKPIFAFDONHBOOANEEMFDNOKIGHJKAJIOAGANIEFDBCFCIAPMOENCHHFFCACAAIIANBOJAACMCNEHEAKAMMANFCBAFDKEFAKJHGADBJHMMDNCOAKINLNBHCFAMOHMJIHHAFKCEAAFILDMOALEOJNACGGMGMDDJHDMAGHJPEFNLELMAIDFAAOFEGENCKBAAKCBAJOKJABFBAPMHKMICJKCEALOIJGFEANKMBNFANHABDEFIPKKKPDANJDKCHKDCABPMCAPDIGOBCFKCHDMMGHHINPKGCPHFGDIHNFMFIGNHBNDAABCABNNPABHCJJAIFMIKEHCAFCOAJCOKACFCDFHNOKAHCCNLEHJABMLGAAFOHGKIHAPOKCJIGMOIGLAOFCNNBHEJINFIFBKPAIHDEADKMHNFMIACANKMCAFJAKDILFKNGMAFEFGIPNAIBBKHOAPHDNFIABNNPMOFIPPHAKJNADAMENMJPCIEEDPEJKFLOHKIAIBKCACCGGAHPAAEJJHMPEDAJBKJOCDGCKKFPMIHINADHJEJHACAGCIBADDAHOAEAFHMFNCAPAODMLAPGHJJFFKJODKAOLHDAPPDPAOHIPOECOOJICLEPKKNOPOCAHMHACGDCAACOKANNEDAEICFNMFPALOCDCAEAHDMNNAANDAKDFFCJNDMIAINAADJPFMANOGNDOBEPIADIOFGGOOFJFMNAOFNICDOIDINFKGPNFBEHIAOIBEPMKJAKBFHJBHPABKDCAAFMONOPFFGEMLNNMPGAMCIKJAIAAFOOACLHNKPPPDEAMKDLAMHIKIFPAKAJBBAOAHIEIOCBOKNHBDOGHBINHBHBACOELMNDMCHNPNBLAAFECKHJMHAADPKANNIINIOEOBACGOIHDAFIACHBOCAOPOCIODCEBKKMMBPIOOINFDCIHBMOOPPIMFBBMAENPOMJFHAGFFGCFHAHNKANDLHMJMIHMNGJJCFEADACCDICLHEOPBMCOFHPEECDOOAJPEAMAAIBMDMEBLIDCCKJCMDDKMNMJNPAEKDHANHEHOCPMCCIFBMCKHHOOKMMKNDCHMDCMFOIGCCLPAHIDECLKKACGFLHCAAIMNNCKCJGCAGNGAHGDCCMNOALKFMALCFIKLHHKNHMAAILCEJMHLABFFJAANMOCKGALMFINECAGAFHNMCMGEMKFPEAOHFBNOOACJOEABNFFHMMNAPKNMDCCKAHPOBPMPAAGJNDNECNDKKIBDFHOKHACCHILMNOEAPJDADFEAACDOCJFDCIDOMHODPIEHKHEAANCAAKFDAFADDKMKIIJFOPKOKEKOFAIANECFOLIKAOEANEHCJACJAINKHAICJDAAHAAICENBACKFLOMAEIKPMAKAJGDCFJNHIABLKEAIHHGBBIAEEGBEMAFMBNFKILPACJPJMEAGJIHJMINFAGGPAHFGNPHDFCOKEKIOMMKFIPICBJFAOEAPPCMDADBNDECAHAKMDDJIAOBOJEHACGJAMHNKAKLMNOOKJIAIAKKAKEOANKIKCJLJMBAJIAIMKCDCHGMCDGFCHELMFPPFPIEPDJOJGEPKNFLAANDAAOFKJIPKEJFCNHCMOPHCHIEDCCAOAFCHNIHDIDBMJAKNNPDMFMDCACFNHLGFJANAAFAKGAAHEFJKAOABNFNHIFENFMOAHBNICJECAAOEAMLOAHGMAFDPIBJAALFMEDOHMDDFEJCDNJENAHOFNGCCAPPNNNJBAAMHAMABMGDACKFNHLKHNCHFGAPOFJEDAIDINAKHDNCHABOKAJIGNOAEIFIJENFAAGHGAONCAKNCCHLMIIAPKEOICKEANPAODNKLCHOHOADECMCAJBCPAEFFABDCBPBNBFMIEJHDAHFAJAJKAAIANEADIJFCNKNHIAPMKHANHHENHHBHPHAHDJCBFAIFDCBMAACOAANDCNPAAJDNDJIKDPACAABKFBMOIPBGOBDFOKBAHLIOFJCOOJAAOAANAANAHAEBDHJLAOCAGMLOHAKNHNAHIAPMEBMCHEGNCOMAHEPNCCGFPEFHDAMPAAPEBEDAIAMIKGNCAOLMNJKMACOPAAMICEDCFCHNOEIPEHOFAHENPIGHAAHOANNNFAPNCBJAEMDKMOHHAHFOKBJDJHIGANCNPIGMHMMMBGPEMMNNBBAMFBPMBBADMNMMBBB";

var alphabet = new List<(string, char)>
{
    ("AN", 'а'),
    ("PG", 'А'),
    ("FH", 'в'),
    ("CM", 'с'),
    ("ON", 'к'),
    ("KJ", 'К'),
    ("IK", 'о'),
    ("KO", 'О'),
    ("AA", ' '),
    ("EI", 'й'),
    ("MB", '*'),
    ("HF", 'Н'),
    ("EM", 'е'),
    ("HC", 'р'),
    ("JA", 'н'),
    ("AF", 'з'),
    ("DD", 'г'),
    ("NB", 'ж'),
    ("HA", 'У'),
    ("OO", 'у'),
    ("OE", 'ш'),
    ("KC", 'х'),
    ("HD", 'м'),
    ("PB", 'М'),
    ("CP", 'ц'),
    ("IO", 'и'),
    ("LH", 'И'),
    ("NO", 'д'),
    ("DH", 'Д'),
    ("PD", 'л'),
    ("BE", 'я'),
    ("HH", 'п'),
    ("LA", 'П'),
    ("GF", 'т'),
    ("NF", 'ь'),
    ("HI", 'э'),
    ("CK", 'ч'),
    ("KK", 'б'),
    ("HN", 'Б'),
    ("PJ", 'ю'),
    ("MF", 'ы'),
    ("CC", 'ф'),
    ("ED", 'щ'),
    ("MH", '-'),
    ("EC", ')'),
    ("LM", '('),
    ("CF", '<'),
    ("HM", '>'),
    ("JE", ','),
    ("GN", '.'),
    ("EG", '-'),
    ("DL", '-'),
    ("OP", '2'),
    ("KB", '4'),
    ("PH", '5'),
    ("DC", '1'),
    ("FO", '9'),
    ("AJ", '0'),
    ("GA", '3'),
    ("BF", '7'),
    ("JF", 'Э'),
    ("EO", 'В'),
    ("MB", 'С'),
    ("IF", 'ё'),
    ("JD", 'Р'),
    ("DB", 'Я'),
    ("IL", 'ъ'),
    ("JB", 'Е'),
    ("MJ", 'Ж'),
    ("IC", 'Г')
};

var positions = new List<(int, int, int)>
{
    (6, 11, 0), // Б
    (13, 4, 1), // е
    (14, 0, 2), // р
    (5, 9, 3), // л
    (22, 27, 4), // и
    (29, 20, 5), // н
    (30, 16, 6), // н
    (21, 25, 7) // н
};


//F3(str2, positions, alphabet);

F3(str, positions, alphabet);


//F1();

Console.WriteLine();




Console.ReadKey();

void F1()
{
    //var s = "AHMONFHCJHKFBAAPCHGLKIGJEKCFHIHAODAFAEEMGMAIBANHAPGEFJJAJAAAENAIFJCIMOACEOHNICGBMDANDJHFFAAHNPENACCCEHIMIDHOHBAEECLBCAAMANJNDHOFCFFMAGPBKNEDCAINNNLLJAAGIAMAHKGMNKGIOIMOCKMJAOOFHEAFAFFMLHPHLAFFAFMEDFEKEHLMNPAKCOCIMAALMNFAKCHHAAHEMINKFOHBPEJKMHAIAAELNALMPACNDBBANJHADAMDIADBMAMPEFOBGHEOIOENKMMFNDCCBDLMJOICHEPBAPICCDDKHAHCOONGPAAGLNBNOCNPNCMLDAHMNADCCHAFJBAMLADEMACCADPENFJEHHDBICKDPFAKIPPDMCNEEMNOPEEKJAGHOAOPLABNBOPDAAHENOGCFNLFDAJHOPJKHPIDDJCKFFOPCNANNHAKADOABAHCAHIAJDILJDPOMPADMMNCAHEPPCOMEJEPNGAADAAJNAPNNPAKAHIDNJPHEBPBKGADJOPBAAGNBNNNPAKCNFHBOIGBNKLFBOOOEEBBNAFCPAJHHAJPKMKKFKCLFKPKOGIDHEOCAAMFIAJFEAFBKEHCFGHFCFOIPGILMJAPBAAEMAKACNEEAGNGMNNEBFBOEEJOKHPFCHAPDCBAGCIJCEJOOICOCKBMCIHKFCGINNFMLFJHCAGDOMDGAPANCDEAPLILODAOPGIAENPOBCODAKAFJFAOLHGAFKAHMMFEKHEGPCHMKCEBFCBKAAOKINJOBAGOOGMGNCJADMPAFOILAKFJFHGECHNFEMAKOGMGKFHDLHMCPINAOHKFAPIKCDPONJOMFHIKMAICAAMOLCNBADNONKJIIBCACAAFHPMGGAAGEJNJPEPIDPGENAAPDAFAKOHAHBOOAIIELKEOBAHHEHFJKPNAHDJOOIOANOODAAIHMABOMAOCNNCJMEHBMMGCMEOCHEDOADGOFLDNCAPHOENIANBCAOPEKAOCAFMICAAOHNJNKHJPNABCAHBBMCFEOAAGEGDOOAHOMANDDIBECDOENFAMFHPFNAKNOJCGFPANBDPNIGICDAPHAIAPOKFNJAHFAEHJFDCAFDOMHGAPFEAOOIHAFKICAOACOKFLKIHMILIHAINBAKBCDIEMPKNMBHJAFDNFFPCPEJCMCGNCJGKCFAAHEAPAJBAGAELDKJGDFAGFKIJDAKKAACGFAMANJAHNEOAJMJHPOABHBEOJOPKGAEIBFMCKDANEFDHEMFEALHLIBCGPNBNOHPIPBDJKKFACPIJEADAMFLDNCAONDPBAAFBJIHFEAADGOCFKCEADNMLNNHNNNBPCMAELMNIIDCOEFAPKAABKNNJEAAGCKMKDNFJDLHJAOOIGAKKDEAACJNNNLBAIOADMDBHCCEDCLHIHMIMLDJAGMAHAJDEPNKMBCPENADIMNHAFBMBDAGABNNENBAMANLFKHAALMAIAOLGGDAGFKNHHOOBNFIDPKBGGAFAFHHDNGJIBANKDNKABKOINLGAHAAKPNOJDHOEAJAAJCFHIFECFMMCMDGHEDEFEOAHJPNODOIPBAAHHFJCAOAPMMNANMHAHAEAFOMLNJACCCAFKMAFNJABHNEHFHAKOAHIMDCEOHAHEHDOHOIIACOFKENFFDKDFOAJHBNAALOPAALPCFJCLPAIMPNAGHNMMAAAGKJANHAPNDAJCNGAFPNAAPOHHMLHOBJAAMADAHDCFAPGFMJIDKAHKEEABKOBEKAECNAKMEKIFFKKMKFHBNHLHFIAPOIBDDPIBLDMKGPIJCIKMABIBDFJKFADBABJGIFDHNHBLCEAGOJCCFOIFHOMKFANHKFPOAEOBGIHEJJINCFMONHAMPDJAKAHPAEJBODIFJDBOMIADMBLJAHEFICIMJJELNFHADAAKCACNMPAKAPICNLMFDHDBBGAHDOFJAOGFPONNPAJGACOAMONFMNEOPEJJCINIABILGFHKKADCAKIMEFAKBHAAKBJIEIOCCAAHOAONCHBEHKEEKECJLMMMOIFKOFLNEGHOBFECAOIEABHGAKNGFBGFNAGPAMIOCCGEEMBAGDAIKKLHDPAMADCNMHIKKHDFFDEHJLMMAGIPDFEAFEFJHMNHOMPFMPLMAFGINHAFGALFMNJGOCACDMFAENEPFDDDFABAJAHEHGNDFHOGCDCNKCBFNDBKMBEFAGOEFFBPFACDAHPENJHBLADCPAJKAAHOMHIJDDOKCEAMFDPFMIEMHKJMACGADGKDOBAELEBADNPKKHLLNJAMEADAMOICKFJDCPGEADIFHHIFKIJJAENABIBFEJICCBBICAAGONKACCHBECHEFAADNAFFCMJEAKNEKCJGGMIAAIAGOPEDIIIMLFLKIENMCNFGMAGGHNHFPHHAKAAAAIAFOKGFDAKJELOBFEPFHMIDJNOCKEJCAEJHMMJEMACFFPFPAAHDDNJDHAAAHGMHOAAPDNEAENFBMCHGHHAGOCDAJHEMCNDHFAFJBAHHEMKBEGOCAANFLABOAJBGMFJINGJCOFHAPACJDJMAHEOLOMOOEHPOEIDBOEJBCCEAHIBMFGJOAGGEFFBNEAJCMDEAAGIFCFJKOACMKMBBDAAINAHNIPIANHDBMIHGDKHCMEOHKMCLOHHDMDHCKNIHDMCJOBAFJEOAKNPDFIEACDABOLJAIDBNHJNGAIEDJKPIFAFDONHBOOANEEMFDNOKIGHJKAJIOAGANIEFDBCFCIAPMOENCHHFFCACAAIIANBOJAACMCNEHEAKAMMANFCBAFDKEFAKJHGADBJHMMDNCOAKINLNBHCFAMOHMJIHHAFKCEAAFILDMOALEOJNACGGMGMDDJHDMAGHJPEFNLELMAIDFAAOFEGENCKBAAKCBAJOKJABFBAPMHKMICJKCEALOIJGFEANKMBNFANHABDEFIPKKKPDANJDKCHKDCABPMCAPDIGOBCFKCHDMMGHHINPKGCPHFGDIHNFMFIGNHBNDAABCABNNPABHCJJAIFMIKEHCAFCOAJCOKACFCDFHNOKAHCCNLEHJABMLGAAFOHGKIHAPOKCJIGMOIGLAOFCNNBHEJINFIFBKPAIHDEADKMHNFMIACANKMCAFJAKDILFKNGMAFEFGIPNAIBBKHOAPHDNFIABNNPMOFIPPHAKJNADAMENMJPCIEEDPEJKFLOHKIAIBKCACCGGAHPAAEJJHMPEDAJBKJOCDGCKKFPMIHINADHJEJHACAGCIBADDAHOAEAFHMFNCAPAODMLAPGHJJFFKJODKAOLHDAPPDPAOHIPOECOOJICLEPKKNOPOCAHMHACGDCAACOKANNEDAEICFNMFPALOCDCAEAHDMNNAANDAKDFFCJNDMIAINAADJPFMANOGNDOBEPIADIOFGGOOFJFMNAOFNICDOIDINFKGPNFBEHIAOIBEPMKJAKBFHJBHPABKDCAAFMONOPFFGEMLNNMPGAMCIKJAIAAFOOACLHNKPPPDEAMKDLAMHIKIFPAKAJBBAOAHIEIOCBOKNHBDOGHBINHBHBACOELMNDMCHNPNBLAAFECKHJMHAADPKANNIINIOEOBACGOIHDAFIACHBOCAOPOCIODCEBKKMMBPIOOINFDCIHBMOOPPIMFBBMAENPOMJFHAGFFGCFHAHNKANDLHMJMIHMNGJJCFEADACCDICLHEOPBMCOFHPEECDOOAJPEAMAAIBMDMEBLIDCCKJCMDDKMNMJNPAEKDHANHEHOCPMCCIFBMCKHHOOKMMKNDCHMDCMFOIGCCLPAHIDECLKKACGFLHCAAIMNNCKCJGCAGNGAHGDCCMNOALKFMALCFIKLHHKNHMAAILCEJMHLABFFJAANMOCKGALMFINECAGAFHNMCMGEMKFPEAOHFBNOOACJOEABNFFHMMNAPKNMDCCKAHPOBPMPAAGJNDNECNDKKIBDFHOKHACCHILMNOEAPJDADFEAACDOCJFDCIDOMHODPIEHKHEAANCAAKFDAFADDKMKIIJFOPKOKEKOFAIANECFOLIKAOEANEHCJACJAINKHAICJDAAHAAICENBACKFLOMAEIKPMAKAJGDCFJNHIABLKEAIHHGBBIAEEGBEMAFMBNFKILPACJPJMEAGJIHJMINFAGGPAHFGNPHDFCOKEKIOMMKFIPICBJFAOEAPPCMDADBNDECAHAKMDDJIAOBOJEHACGJAMHNKAKLMNOOKJIAIAKKAKEOANKIKCJLJMBAJIAIMKCDCHGMCDGFCHELMFPPFPIEPDJOJGEPKNFLAANDAAOFKJIPKEJFCNHCMOPHCHIEDCCAOAFCHNIHDIDBMJAKNNPDMFMDCACFNHLGFJANAAFAKGAAHEFJKAOABNFNHIFENFMOAHBNICJECAAOEAMLOAHGMAFDPIBJAALFMEDOHMDDFEJCDNJENAHOFNGCCAPPNNNJBAAMHAMABMGDACKFNHLKHNCHFGAPOFJEDAIDINAKHDNCHABOKAJIGNOAEIFIJENFAAGHGAONCAKNCCHLMIIAPKEOICKEANPAODNKLCHOHOADECMCAJBCPAEFFABDCBPBNBFMIEJHDAHFAJAJKAAIANEADIJFCNKNHIAPMKHANHHENHHBHPHAHDJCBFAIFDCBMAACOAANDCNPAAJDNDJIKDPACAABKFBMOIPBGOBDFOKBAHLIOFJCOOJAAOAANAANAHAEBDHJLAOCAGMLOHAKNHNAHIAPMEBMCHEGNCOMAHEPNCCGFPEFHDAMPAAPEBEDAIAMIKGNCAOLMNJKMACOPAAMICEDCFCHNOEIPEHOFAHENPIGHAAHOANNNFAPNCBJAEMDKMOHHAHFOKBJDJHIGANCNPIGMHMMMBGPEMMNNBBAMFBPMBBADMNMMBBB";

    var s1 = "CADKMPHFHDFNAEHMMHOBABIOCMGOFJBK";
    var s2 = "CJIOMPHJFDLNFEHOMHBDABIDMMHOBJBH";
    var s4 = "NCBJAEMDKMOHHAHFOKBJDJHIGANCNPIG";

    var s3 = "";
    var s5 = "";

    for (int i = 0; i < s1.Length; i++)
    {


        //if (i == s1.Length / 2) s3 += "\n";
        if (i % 4 == 0)
        {
            s3 += "  ";
            s5 += "  ";
        }
        if (s1[i] == s2[i])
        {
            s3 += s1[i] + $"({i}) ";
            s5 += s4[i] + $"({i}) ";

            /* s3 += s1[i] + " ";
             s5 += s4[i] + " ";*/
        }

        else
        {
            s3 += "_" + $"({i}) ";
            s5 += "_" + $"({i}) ";
        }

    }


    Console.WriteLine("Берлин");
    Console.WriteLine();
    Console.WriteLine(s1);
    Console.WriteLine(s3);

    Console.WriteLine();
    Console.WriteLine(s2);
    Console.WriteLine(s3);

    Console.WriteLine();
    Console.WriteLine(s4);
    Console.WriteLine(s5);

}


void F3(string str, List<(int, int, int)> positions, List<(string, char)> alphabet)
{
    //var str = "AHMONFHCJHKFBAAPCHGLKIGJEKCFHIHAODAFAEEMGMAIBANHAPGEFJJAJAAAENAIFJCIMOACEOHNICGBMDANDJHFFAAHNPENACCCEHIMIDHOHBAEECLBCAAMANJNDHOFCFFMAGPBKNEDCAINNNLLJAAGIAMAHKGMNKGIOIMOCKMJAOOFHEAFAFFMLHPHLAFFAFMEDFEKEHLMNPAKCOCIMAALMNFAKCHHAAHEMINKFOHBPEJKMHAIAAELNALMPACNDBBANJHADAMDIADBMAMPEFOBGHEOIOENKMMFNDCCBDLMJOICHEPBAPICCDDKHAHCOONGPAAGLNBNOCNPNCMLDAHMNADCCHAFJBAMLADEMACCADPENFJEHHDBICKDPFAKIPPDMCNEEMNOPEEKJAGHOAOPLABNBOPDAAHENOGCFNLFDAJHOPJKHPIDDJCKFFOPCNANNHAKADOABAHCAHIAJDILJDPOMPADMMNCAHEPPCOMEJEPNGAADAAJNAPNNPAKAHIDNJPHEBPBKGADJOPBAAGNBNNNPAKCNFHBOIGBNKLFBOOOEEBBNAFCPAJHHAJPKMKKFKCLFKPKOGIDHEOCAAMFIAJFEAFBKEHCFGHFCFOIPGILMJAPBAAEMAKACNEEAGNGMNNEBFBOEEJOKHPFCHAPDCBAGCIJCEJOOICOCKBMCIHKFCGINNFMLFJHCAGDOMDGAPANCDEAPLILODAOPGIAENPOBCODAKAFJFAOLHGAFKAHMMFEKHEGPCHMKCEBFCBKAAOKINJOBAGOOGMGNCJADMPAFOILAKFJFHGECHNFEMAKOGMGKFHDLHMCPINAOHKFAPIKCDPONJOMFHIKMAICAAMOLCNBADNONKJIIBCACAAFHPMGGAAGEJNJPEPIDPGENAAPDAFAKOHAHBOOAIIELKEOBAHHEHFJKPNAHDJOOIOANOODAAIHMABOMAOCNNCJMEHBMMGCMEOCHEDOADGOFLDNCAPHOENIANBCAOPEKAOCAFMICAAOHNJNKHJPNABCAHBBMCFEOAAGEGDOOAHOMANDDIBECDOENFAMFHPFNAKNOJCGFPANBDPNIGICDAPHAIAPOKFNJAHFAEHJFDCAFDOMHGAPFEAOOIHAFKICAOACOKFLKIHMILIHAINBAKBCDIEMPKNMBHJAFDNFFPCPEJCMCGNCJGKCFAAHEAPAJBAGAELDKJGDFAGFKIJDAKKAACGFAMANJAHNEOAJMJHPOABHBEOJOPKGAEIBFMCKDANEFDHEMFEALHLIBCGPNBNOHPIPBDJKKFACPIJEADAMFLDNCAONDPBAAFBJIHFEAADGOCFKCEADNMLNNHNNNBPCMAELMNIIDCOEFAPKAABKNNJEAAGCKMKDNFJDLHJAOOIGAKKDEAACJNNNLBAIOADMDBHCCEDCLHIHMIMLDJAGMAHAJDEPNKMBCPENADIMNHAFBMBDAGABNNENBAMANLFKHAALMAIAOLGGDAGFKNHHOOBNFIDPKBGGAFAFHHDNGJIBANKDNKABKOINLGAHAAKPNOJDHOEAJAAJCFHIFECFMMCMDGHEDEFEOAHJPNODOIPBAAHHFJCAOAPMMNANMHAHAEAFOMLNJACCCAFKMAFNJABHNEHFHAKOAHIMDCEOHAHEHDOHOIIACOFKENFFDKDFOAJHBNAALOPAALPCFJCLPAIMPNAGHNMMAAAGKJANHAPNDAJCNGAFPNAAPOHHMLHOBJAAMADAHDCFAPGFMJIDKAHKEEABKOBEKAECNAKMEKIFFKKMKFHBNHLHFIAPOIBDDPIBLDMKGPIJCIKMABIBDFJKFADBABJGIFDHNHBLCEAGOJCCFOIFHOMKFANHKFPOAEOBGIHEJJINCFMONHAMPDJAKAHPAEJBODIFJDBOMIADMBLJAHEFICIMJJELNFHADAAKCACNMPAKAPICNLMFDHDBBGAHDOFJAOGFPONNPAJGACOAMONFMNEOPEJJCINIABILGFHKKADCAKIMEFAKBHAAKBJIEIOCCAAHOAONCHBEHKEEKECJLMMMOIFKOFLNEGHOBFECAOIEABHGAKNGFBGFNAGPAMIOCCGEEMBAGDAIKKLHDPAMADCNMHIKKHDFFDEHJLMMAGIPDFEAFEFJHMNHOMPFMPLMAFGINHAFGALFMNJGOCACDMFAENEPFDDDFABAJAHEHGNDFHOGCDCNKCBFNDBKMBEFAGOEFFBPFACDAHPENJHBLADCPAJKAAHOMHIJDDOKCEAMFDPFMIEMHKJMACGADGKDOBAELEBADNPKKHLLNJAMEADAMOICKFJDCPGEADIFHHIFKIJJAENABIBFEJICCBBICAAGONKACCHBECHEFAADNAFFCMJEAKNEKCJGGMIAAIAGOPEDIIIMLFLKIENMCNFGMAGGHNHFPHHAKAAAAIAFOKGFDAKJELOBFEPFHMIDJNOCKEJCAEJHMMJEMACFFPFPAAHDDNJDHAAAHGMHOAAPDNEAENFBMCHGHHAGOCDAJHEMCNDHFAFJBAHHEMKBEGOCAANFLABOAJBGMFJINGJCOFHAPACJDJMAHEOLOMOOEHPOEIDBOEJBCCEAHIBMFGJOAGGEFFBNEAJCMDEAAGIFCFJKOACMKMBBDAAINAHNIPIANHDBMIHGDKHCMEOHKMCLOHHDMDHCKNIHDMCJOBAFJEOAKNPDFIEACDABOLJAIDBNHJNGAIEDJKPIFAFDONHBOOANEEMFDNOKIGHJKAJIOAGANIEFDBCFCIAPMOENCHHFFCACAAIIANBOJAACMCNEHEAKAMMANFCBAFDKEFAKJHGADBJHMMDNCOAKINLNBHCFAMOHMJIHHAFKCEAAFILDMOALEOJNACGGMGMDDJHDMAGHJPEFNLELMAIDFAAOFEGENCKBAAKCBAJOKJABFBAPMHKMICJKCEALOIJGFEANKMBNFANHABDEFIPKKKPDANJDKCHKDCABPMCAPDIGOBCFKCHDMMGHHINPKGCPHFGDIHNFMFIGNHBNDAABCABNNPABHCJJAIFMIKEHCAFCOAJCOKACFCDFHNOKAHCCNLEHJABMLGAAFOHGKIHAPOKCJIGMOIGLAOFCNNBHEJINFIFBKPAIHDEADKMHNFMIACANKMCAFJAKDILFKNGMAFEFGIPNAIBBKHOAPHDNFIABNNPMOFIPPHAKJNADAMENMJPCIEEDPEJKFLOHKIAIBKCACCGGAHPAAEJJHMPEDAJBKJOCDGCKKFPMIHINADHJEJHACAGCIBADDAHOAEAFHMFNCAPAODMLAPGHJJFFKJODKAOLHDAPPDPAOHIPOECOOJICLEPKKNOPOCAHMHACGDCAACOKANNEDAEICFNMFPALOCDCAEAHDMNNAANDAKDFFCJNDMIAINAADJPFMANOGNDOBEPIADIOFGGOOFJFMNAOFNICDOIDINFKGPNFBEHIAOIBEPMKJAKBFHJBHPABKDCAAFMONOPFFGEMLNNMPGAMCIKJAIAAFOOACLHNKPPPDEAMKDLAMHIKIFPAKAJBBAOAHIEIOCBOKNHBDOGHBINHBHBACOELMNDMCHNPNBLAAFECKHJMHAADPKANNIINIOEOBACGOIHDAFIACHBOCAOPOCIODCEBKKMMBPIOOINFDCIHBMOOPPIMFBBMAENPOMJFHAGFFGCFHAHNKANDLHMJMIHMNGJJCFEADACCDICLHEOPBMCOFHPEECDOOAJPEAMAAIBMDMEBLIDCCKJCMDDKMNMJNPAEKDHANHEHOCPMCCIFBMCKHHOOKMMKNDCHMDCMFOIGCCLPAHIDECLKKACGFLHCAAIMNNCKCJGCAGNGAHGDCCMNOALKFMALCFIKLHHKNHMAAILCEJMHLABFFJAANMOCKGALMFINECAGAFHNMCMGEMKFPEAOHFBNOOACJOEABNFFHMMNAPKNMDCCKAHPOBPMPAAGJNDNECNDKKIBDFHOKHACCHILMNOEAPJDADFEAACDOCJFDCIDOMHODPIEHKHEAANCAAKFDAFADDKMKIIJFOPKOKEKOFAIANECFOLIKAOEANEHCJACJAINKHAICJDAAHAAICENBACKFLOMAEIKPMAKAJGDCFJNHIABLKEAIHHGBBIAEEGBEMAFMBNFKILPACJPJMEAGJIHJMINFAGGPAHFGNPHDFCOKEKIOMMKFIPICBJFAOEAPPCMDADBNDECAHAKMDDJIAOBOJEHACGJAMHNKAKLMNOOKJIAIAKKAKEOANKIKCJLJMBAJIAIMKCDCHGMCDGFCHELMFPPFPIEPDJOJGEPKNFLAANDAAOFKJIPKEJFCNHCMOPHCHIEDCCAOAFCHNIHDIDBMJAKNNPDMFMDCACFNHLGFJANAAFAKGAAHEFJKAOABNFNHIFENFMOAHBNICJECAAOEAMLOAHGMAFDPIBJAALFMEDOHMDDFEJCDNJENAHOFNGCCAPPNNNJBAAMHAMABMGDACKFNHLKHNCHFGAPOFJEDAIDINAKHDNCHABOKAJIGNOAEIFIJENFAAGHGAONCAKNCCHLMIIAPKEOICKEANPAODNKLCHOHOADECMCAJBCPAEFFABDCBPBNBFMIEJHDAHFAJAJKAAIANEADIJFCNKNHIAPMKHANHHENHHBHPHAHDJCBFAIFDCBMAACOAANDCNPAAJDNDJIKDPACAABKFBMOIPBGOBDFOKBAHLIOFJCOOJAAOAANAANAHAEBDHJLAOCAGMLOHAKNHNAHIAPMEBMCHEGNCOMAHEPNCCGFPEFHDAMPAAPEBEDAIAMIKGNCAOLMNJKMACOPAAMICEDCFCHNOEIPEHOFAHENPIGHAAHOANNNFAPNCBJAEMDKMOHHAHFOKBJDJHIGANCNPIGMHMMMBGPEMMNNBBAMFBPMBBADMNMMBBB";


    int count = 0;
    List<string> arr = new List<string>();

    while (str.Length / 32 > count)
    {
        arr.Add(string.Empty);
        for (int i = 0; i < 32; i++)
        {
            arr[count] += str[i + (count * 32)];
        }
        count++;
    }



    string result = string.Empty;
    foreach (var item in arr)
    {

        string dec = "*";
        dec = dec.PadRight(8, '*');
        var sb = new StringBuilder(dec);

        foreach (var letter in alphabet)
        {
            foreach (var pos in positions)
            {
                if (item[pos.Item1] == letter.Item1[0]
                    && item[pos.Item2] == letter.Item1[1])
                {
                    sb[pos.Item3] = letter.Item2;
                }
            }
        }

        Console.WriteLine(item);
        Console.WriteLine(sb);

        result += sb;
    }

    Console.WriteLine(result);

    Console.ReadKey();
}

