Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                AxWindowsMediaPlayer1.URL = ("http://dminnvll.cdn.mangomolo.com/dubaione/smil:dubaione.stream.smil/chunklist_b380000.m3u8")
            Case 1
                AxWindowsMediaPlayer1.URL = ("http://dmiffthvll.cdn.mangomolo.com/noordubaitv/smil:noordubaitv.smil/chunklist_b1500000.m3u8")
            Case 2
                AxWindowsMediaPlayer1.URL = ("http://dmiffthvll.cdn.mangomolo.com/dubaizaman/smil:dubaizaman.stream.smil/chunklist_b1500000.m3u8")
            Case 3
                AxWindowsMediaPlayer1.URL = ("http://dmisvthvll.cdn.mangomolo.com/events/smil:events.smil/chunklist.m3u8")
            Case 4
                AxWindowsMediaPlayer1.URL = ("https://svs.itworkscdn.net/smc1live/smc1.smil/playlist.m3u8")
            Case 5
                AxWindowsMediaPlayer1.URL = ("http://iqraac.cdn.mangomolo.com/iqraa/smil:iqraar1.stream.smil/chunklist_b1800000_t64NTc2cA==.m3u8")
            Case 6
                AxWindowsMediaPlayer1.URL = ("http://makkahtv.srfms.com:1935/makkahtv/livestream/chunklist_w1150651953.m3u8")
            Case 7
                AxWindowsMediaPlayer1.URL = ("http://jmc-live.ercdn.net/alistiqama/alistiqama_576p.m3u8")
            Case 8
                AxWindowsMediaPlayer1.URL = ("http://livecdnh2.tvanywhere.ae/hls/blue_nile/04.m3u8")
            Case 9
                AxWindowsMediaPlayer1.URL = ("http://51.15.246.58:8081/watantv_source2/live/chunks.m3u8")
            Case 10
                AxWindowsMediaPlayer1.URL = ("http://htvajyal.mada.ps:8888/ajyal/tracks-v1a1/mono.m3u8")
            Case 11
                AxWindowsMediaPlayer1.URL = ("http://149.202.79.190:8081/elsharqtv/live_1024p/chunks.m3u8")
            Case 12
                AxWindowsMediaPlayer1.URL = ("http://mn-nl.mncdn.com/mekameleen/smil:mekameleentv.smil/chunklist_b1864000.m3u8?")
            Case 13
                AxWindowsMediaPlayer1.URL = ("http://cdn.catiacast.video/imn/2d51fe4a0ba54894421ead1809309ed9.sdp/chunks.m3u8")
            Case 14
                AxWindowsMediaPlayer1.URL = ("http://38.96.175.40:1935/liveTrans//channel5_190k/chunklist_w1412664744.m3u8")
            Case 15
                'موجز الأخبار
                Me.Label1.Text = "موجز الأخبار"
                AxWindowsMediaPlayer1.URL = ("https://svs.itworkscdn.net/alminbartvlive/alminbar/chunks.m3u8")
            Case 16
                'الحره
                Me.Label1.Text = "الحره"
                AxWindowsMediaPlayer1.URL = ("http://95.170.215.109/hls/m3u8/SAMA-TV-Backup.m3u8")
            Case 17
                'l19 اخبار
                Me.Label1.Text = "l19 اخبار"
                AxWindowsMediaPlayer1.URL = ("https://svs.itworkscdn.net/syriatvlive/syriatv.smil/playlist.m3u8")
            Case 18
                AxWindowsMediaPlayer1.URL = ("http://wowzacontrol.com:1935/8010/8010/chunklist_w278367314.m3u8")
            Case 19
                'قناه كيف
                Me.Label1.Text = "قناه كيف"
                AxWindowsMediaPlayer1.URL = ("http://82.212.74.2:8000/live/hls/7311.m3u8")
            Case 20
                'المملكه
                Me.Label1.Text = "المملكه"
                AxWindowsMediaPlayer1.URL = ("https://almamlka-live.ercdn.net/almamlka/almamlka_1080p.m3u8")
            Case 21
                'ksy news العربيه
                Me.Label1.Text = "ksy news العربيه"
                AxWindowsMediaPlayer1.URL = ("https://stream.skynewsarabia.com/hls/sna_720.m3u8")
            Case 22
                'وطن
                Me.Label1.Text = "وطن"
                AxWindowsMediaPlayer1.URL = ("http://watantv.origin.technostreaming.net:8081/watantv_source2/live/chunks.m3u8")
            Case 23
                'الحره
                Me.Label1.Text = "الحره"
                AxWindowsMediaPlayer1.URL = ("http://mbnhls-lh.akamaihd.net/i/MBN_1@118619/master.m3u8")
            Case 24
                'دبي الرياضه
                Me.Label1.Text = "دبي الرياضه"
                AxWindowsMediaPlayer1.URL = ("http://dmitnthvll.cdn.mangomolo.com/dubaisports/smil:dubaisports.smil/chunklist_b1600000.m3u8")
            Case 25
                'DubaiRacing 2
                Me.Label1.Text = "DubaiRacing 2"
                AxWindowsMediaPlayer1.URL = ("http://dmithrvll.cdn.mangomolo.com/dubairacing/smil:dubairacing.smil/chunklist_b1600000.m3u8")
            Case 26
                'البحرين الرياضية
                Me.Label1.Text = "البحرين الرياضية"
                AxWindowsMediaPlayer1.URL = ("http://185.105.4.106:1935/live/Bahrain%20Sports/chunklist.m3u8")
            Case 27
                'maroc SPORT
                Me.Label1.Text = "maroc SPORT"
                AxWindowsMediaPlayer1.URL = ("http://cdnamd-hls-globecast.akamaized.net/live/ramdisk/arriadia/hls_snrt/arriadia-avc1_1500000=4-mp4a_130400_qad=1.m3u8")
            Case 28
                'KURDISH
                Me.Label1.Text = "KURDISH"
                AxWindowsMediaPlayer1.URL = ("http://31.14.40.139:1935/liveTrans/SHOW1/playlist.m3u8")
            Case 29
                'KURDMAX
                Me.Label1.Text = "KURDMAX"
                AxWindowsMediaPlayer1.URL = ("http://31.14.40.139:1935/liveTrans/myStream/chunklist_w1174064262.m3u8")
            Case 30
                'KU-Rudaw
                Me.Label1.Text = "KU-Rudaw"
                AxWindowsMediaPlayer1.URL = ("https://svs.itworkscdn.net/rudawlive/rudawlive.smil/playlist.m3u8")
            Case 31
                'Alquran Kareem
                Me.Label1.Text = "'Alquran Kareem"
                AxWindowsMediaPlayer1.URL = ("https://iptv.mwafa.net/vidio/6852/index.m3u8?token=1999")
            Case 32
                'EXTINF
                Me.Label1.Text = "EXTINF"
                AxWindowsMediaPlayer1.URL = ("https://cdn.alarab.com/h264/156600_480p.mp4/index-v1-a1.m3u8")
            Case 33
                'كل العرب
                Me.Label1.Text = "كل العرب"
                AxWindowsMediaPlayer1.URL = ("https://cdn.alarab.com/h264/156611_480p.mp4/index-v1-a1.m3u8")
            Case 34
                '2m monde
                Me.Label1.Text = "2m monde"
                AxWindowsMediaPlayer1.URL = ("https://cdnamd-hls-globecast.akamaized.net/live/ramdisk/2m_monde/hls_video_ts/2m_monde.m3u8")
            Case 35
                'abn arabic
                Me.Label1.Text = "abn arabic"
                AxWindowsMediaPlayer1.URL = ("http://rtmp1.abnsat.com/hls/arabic.m3u8")
            Case 36
                'أبو ضبي
                Me.Label1.Text = "أبو ضبي"
                AxWindowsMediaPlayer1.URL = ("https://admdn2.cdn.mangomolo.com/adtv/smil:adtv.stream.smil/playlist.m3u8")
            Case 37
                'ابو ظبي دراما
                Me.Label1.Text = "ابو ظبي دراما"
                AxWindowsMediaPlayer1.URL = ("https://admdn5.cdn.mangomolo.com/drama/smil:drama.stream.smil/playlist.m3u8")
            Case 38
                'الأمارات
                Me.Label1.Text = "الأمارات"
                AxWindowsMediaPlayer1.URL = ("https://admdn3.cdn.mangomolo.com/emarat/smil:emarat.stream.smil/playlist.m3u8")
            Case 39
                'ابو ظبي الرياضيه
                Me.Label1.Text = "ابو ظبي الرياضيه"
                AxWindowsMediaPlayer1.URL = ("https://admdn1.cdn.mangomolo.com/adsports1/smil:adsports1.stream.smil/playlist.m3u8")
            Case 40
                'ابو ظبي الرياضيه 2
                Me.Label1.Text = "ابو ظبي الرياضيه 2"
                AxWindowsMediaPlayer1.URL = ("https://admdn5.cdn.mangomolo.com/adsports2/smil:adsports2.stream.smil/playlist.m3u8")
            Case 41
                'ابو ظبي الرياضيه 3
                Me.Label1.Text = "ابو ظبي الرياضيه 3"
                AxWindowsMediaPlayer1.URL = ("https://admdn3.cdn.mangomolo.com/adsports3/smil:adsports3.stream.smil/playlist.m3u8")
            Case 42
                'ابو ظبي تي في 
                Me.Label1.Text = "ابو ظبي تي في"
                AxWindowsMediaPlayer1.URL = ("http://africatv.live.net.sa:1935/live/africatv/playlist.m3u8")
            Case 43
                'تي في دراما
                Me.Label1.Text = "تي في دراما"
                AxWindowsMediaPlayer1.URL = ("http://africatv.live.net.sa:1935/live/africatv2/playlist.m3u8")
            Case 44
                'أجيال
                Me.Label1.Text = "أجيال"
                AxWindowsMediaPlayer1.URL = ("http://htvajyal.mada.ps:8888/ajyal/index.m3u8")
            Case 45
                'Al Alam
                Me.Label1.Text = " 'Al Alam"
                AxWindowsMediaPlayer1.URL = ("https://live2.alalam.ir/alalam.m3u8")
            Case 46
                'Al Aoula Laayoune
                Me.Label1.Text = " 'Al Aoula Laayoune"
                AxWindowsMediaPlayer1.URL = ("http://cdn-hls.globecast.tv/live/ramdisk/al_aoula_laayoune/hls_snrt/index.m3u8")
            Case 47
                'العربيه
                Me.Label1.Text = "  'العربيه"
                AxWindowsMediaPlayer1.URL = ("https://live.alarabiya.net/alarabiapublish/alarabiya.smil/playlist.m3u8")
            Case 48
                'الحيات تي في 
                Me.Label1.Text = "'الحيات تي في "
                AxWindowsMediaPlayer1.URL = ("http://media.islamexplained.com:1935/live/_definst_mp4:ahme.stream/playlist.m3u8")
            Case 49
                'Al Horreya TV
                Me.Label1.Text = "'Al Horreya TV"
                AxWindowsMediaPlayer1.URL = ("http://media.smc-host.com:1935/alhorreya.tv/alhorreya.smil/playlist.m3u8")
            Case 50
                'Al Ittihad
                Me.Label1.Text = "Al Ittihad"
                AxWindowsMediaPlayer1.URL = ("https://live.alittihad.tv/ittihad/index.m3u8")
            Case 51
                'Al Jazeera Arabic الجزيره عربي
                Me.Label1.Text = ""
                AxWindowsMediaPlayer1.URL = ("Al Jazeera Arabic")
            Case 52
                'Al Jazeera Mubasher
                Me.Label1.Text = ""
                AxWindowsMediaPlayer1.URL = ("https://live-hls-web-ajm.getaj.net/AJM/index.m3u8")
            Case 53
                'Al Maaref TV المعرف
                Me.Label1.Text = ""
                AxWindowsMediaPlayer1.URL = ("http://38.96.175.40:1935/liveTrans/ngrp:channel23_all/playlist.m3u8")
            Case 54
                'Al Maghribia المغربيه
                Me.Label1.Text = ""
                AxWindowsMediaPlayer1.URL = ("https://cdnamd-hls-globecast.akamaized.net/live/ramdisk/al_maghribia_snrt/hls_snrt/index.m3u8")
            Case 55
                'المملكهAl Mamlaka TV
                Me.Label1.Text = ""
                AxWindowsMediaPlayer1.URL = ("https://almamlka-live.ercdn.net/almamlka/almamlka.m3u8")
            Case 56
                'Al Manar المنار
                Me.Label1.Text = ""
                AxWindowsMediaPlayer1.URL = ("https://manar.live/iptv/playlist.m3u8")
            Case 57
                'Al Sharqiya News الشرقيه نيوز
                Me.Label1.Text = "Al Sharqiya News الشرقيه نيوز"
                AxWindowsMediaPlayer1.URL = ("http://ns8.indexforce.com:1935/alsharqiyalive/mystream/playlist.m3u8")
            Case 58
                'الفجر
                Me.Label1.Text = "'الفجر"
                AxWindowsMediaPlayer1.URL = ("http://two.alfajertv.com:8081/AlfajertvHDTwo_web/web/playlist.m3u8")
            Case 59
                'KTV Sport ARB
                Me.Label1.Text = "KTV Sport ARB"
                AxWindowsMediaPlayer1.URL = ("https://hiplayer.hibridcdn.net/t/kwmedia-kwtvsports.m3u8")
            Case 60
                'KTVSportPlus
                Me.Label1.Text = "KTVSportPlus"
                AxWindowsMediaPlayer1.URL = ("https://hiplayer.hibridcdn.net/t/kwmedia-kwtvsportsplus.m3u8")
            Case 61
                AxWindowsMediaPlayer1.URL = ("https://shls-mbc-masr-usa-prod.shahid.net/out/v1/d4fded7d5df04b88b9ea1db61d00f095/index.m3u8")
            Case 62
                'Nablus TV نابلس
                Me.Label1.Text = "Nablus TV نابلس"
                AxWindowsMediaPlayer1.URL = ("http://htvmada.mada.ps:8888/nabluslive/index.m3u8")
            Case 63
                'National Geographic Abu Dhabi
                Me.Label1.Text = "National Geographic Abu Dhabi"
                AxWindowsMediaPlayer1.URL = ("http://admdn2.cdn.mangomolo.com/nagtv/smil:nagtv.stream.smil/playlist.m3u8")
            Case 64
                'Oman Sport عمان الرياضيه
                Me.Label1.Text = "'Oman Sport عمان الرياضيه"
                AxWindowsMediaPlayer1.URL = ("https://partne.cdn.mangomolo.com/omsport/smil:omsport.stream.smil/playlist.m3u8")
            Case 65
                'Omg Channel TV
                Me.Label1.Text = " 'Omg Channel TV"
                AxWindowsMediaPlayer1.URL = ("http://media6.smc-host.com:1935/omgchannel.net/omgtv/playlist.m3u8")
            Case 66
                'Palestine Mubasher فلسطين مباشر
                Me.Label1.Text = "'Palestine Mubasher فلسطين مباشر"
                AxWindowsMediaPlayer1.URL = ("http://htvpalsat.mada.ps:8888/PBCLive/index.m3u8")
            Case 67
                'Palestine Satellite Channel فلسطين ستلايت
                Me.Label1.Text = "Palestine Satellite Channel فلسطين ستلايت"
                AxWindowsMediaPlayer1.URL = ("http://htvpalsat.mada.ps:8888/PBC/index.m3u8")
            Case 68
                'palestiniantv فلسطين تي في
                Me.Label1.Text = "palestiniantv فلسطين تي في"
                AxWindowsMediaPlayer1.URL = ("http://palestiniantv.origin.technostreaming.net:8081/palestiniantv_source/live/playlist.m3u8")
            Case 69
                'Panorama FM بانوراما اف ام
                Me.Label1.Text = "Panorama FM بانوراما اف ام"
                AxWindowsMediaPlayer1.URL = ("https://shls-panoramafm-prod-dub.shahid.net/out/v1/66262e420d824475aaae794dc2d69f14/index.m3u8")
            Case 70
                'Rotana Cinema روتانا سينما
                Me.Label1.Text = "Rotana Cinema روتانا سينما"
                AxWindowsMediaPlayer1.URL = ("https://hiplayer.hibridcdn.net/t/rotana-cinema.m3u8")
            Case 71
                'Rotana Classic روتانا كلاسيك
                Me.Label1.Text = "Rotana Classic روتانا كلاسيك"
                AxWindowsMediaPlayer1.URL = ("https://hiplayer.hibridcdn.net/t/rotana-classical.m3u8")
            Case 72
                'Rotana Radio Jordan روتانا رايدو الأردن
                Me.Label1.Text = "Rotana Radio Jordan روتانا رايدو الأردن"
                AxWindowsMediaPlayer1.URL = ("http://188.247.86.66/RotanaRadio/OnAirStudio1/playlist.m3u8")
            Case 73
                'Sharjah Sports الشرقيه الرياضيه
                Me.Label1.Text = "Sharjah Sports الشرقيه الرياضيه"
                AxWindowsMediaPlayer1.URL = ("https://svs.itworkscdn.net/smc4sportslive/smc4.smil/playlist.m3u8")
            Case 74
                'Spacetoon سبيستون
                Me.Label1.Text = "Spacetoon سبيستون"
                AxWindowsMediaPlayer1.URL = ("https://shls-spacetoon-prod-dub.shahid.net/out/v1/6240b773a3f34cca95d119f9e76aec02/index.m3u8")
            Case 75
                'AR:SYR-SYRIA PLUS
                Me.Label1.Text = "AR:SYR-SYRIA PLUS"
                AxWindowsMediaPlayer1.URL = ("https://svs.itworkscdn.net/syriatvlive/syriatv.smil/playlist.m3u8")
            Case 76
                'AR:SYR-HALAB TODAY حلب اليوم
                Me.Label1.Text = "AR:SYR-HALAB TODAY حلب اليوم"
                AxWindowsMediaPlayer1.URL = ("http://wowzacontrol.com:1935/8010/8010/playlist.m3u8")
            Case 77
                'ALL Sports
                Me.Label1.Text = "ALL Sports"
                AxWindowsMediaPlayer1.URL = ("https://5cf4a2c2512a2.streamlock.net/dgrau/dgrau/chunklist.m3u8")
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub
End Class
