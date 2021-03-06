﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace karthik20522
{
    public class ColorConstants
    {
        public static List<string> ValidColors = new List<string>()
        {
            "003366", "336699", "3366cc", "003399", "000099", "0000cc", "000066",
            "006666", "006699", "0099cc", "0066cc", "0033cc", "0000ff", "3333ff", 
            "333399", "669999", "009999", "33cccc", "00ccff", "0099ff", "0066ff", 
            "3366ff", "3333cc", "666699", "339966", "00cc99", "00ffcc", "00ffff", 
            "33ccff", "3399ff", "6699ff", "6666ff", "6600ff", "6600cc", "339933", 
            "00cc66", "00ff99", "66ffcc", "66ffff", "66ccff", "99ccff", "9999ff", 
            "9966ff", "9933ff", "9900ff", "006600", "00cc00", "00ff00", "66ff99", 
            "99ffcc", "ccffff", "ccccff", "cc99ff", "cc66ff", "cc33ff", "cc00ff", 
            "9900cc", "003300", "009933", "33cc33", "66ff66", "99ff99", "ccffcc", 
            "ffffff", "ffccff", "ff99ff", "ff66ff", "ff00ff", "cc00cc", "660066",
            "333300", "009900", "66ff33", "99ff66", "ccff99", "ffffcc", "ffcccc", 
            "ff99cc", "ff66cc", "ff33cc", "cc0099", "993399", "336600", "669900", 
            "99ff33", "ccff66", "ffff99", "ffcc99", "ff9999", "ff6699", "ff3399", 
            "cc3399", "990099", "666633", "99cc00", "ccff33", "ffff66", "ffcc66", 
            "ff9966", "ff6666", "ff0066", "d60094", "993366", "a58800", "cccc00", 
            "ffff00", "ffcc00", "ff9933", "ff6600", "ff0033", "cc0066", "660033",
            "996633", "cc9900", "ff9900", "cc6600", "ff3300", "ff0000", "cc0000", 
            "990033", "663300", "996600", "cc3300", "993300", "990000", "800000", 
            "993333", "ffffff", "ebebeb", "d7d7d7", "c3c3c3", "afafaf", "9b9b9b",
            "878787", "737373", "5f5f5f", "4b4b4b", "373737", "232323", "0f0f0f",
            "f5f5f5", "e1e1e1", "cdcdcd", "b9b9b9", "a5a5a5", "919191", "7d7d7d",
            "696969", "555555", "414141", "2d2d2d", "191919", "050505"
        };

        public static Dictionary<string, List<string>> MonoColors = new Dictionary<string, List<string>>()
        {
            { "003366", new List<string>() {"000d1a","001a33","00264d","003366","004080","004d99","0059b3" } },
            { "336699", new List<string>() {"204060","264d73","2d5986","336699","3973ac","4080bf","538cc6" } },
            { "3366cc", new List<string>() {"24478f","2952a3","2e5cb8","3366cc","4775d1","5c85d6","7094db" } },
            { "003399", new List<string>() {"001a4d","002266","002b80","003399","003cb3","0044cc","004de6" } },
            { "000099", new List<string>() {"00004d","000066","000080","000099","0000b3","0000cc","0000e6" } },
            { "0000cc", new List<string>() {"000080","000099","0000b3","0000cc","0000e6","0000ff","1a1aff" } },
            { "000066", new List<string>() {"00001a","000033","00004d","000066","000080","000099","0000b3" } },
            { "006666", new List<string>() {"001a1a","003333","004d4d","006666","008080","009999","00b3b3" } },
            { "006699", new List<string>() {"00334d","004466","005580","006699","0077b3","0088cc","0099e6" } },
            { "0099cc", new List<string>() {"006080","007399","0086b3","0099cc","00ace6","00bfff","1ac6ff" } },
            { "0066cc", new List<string>() {"004080","004d99","0059b3","0066cc","0073e6","0080ff","1a8cff" } },
            { "0033cc", new List<string>() {"002080","002699","002db3","0033cc","0039e6","0040ff","1a53ff" } },
            { "0000ff", new List<string>() {"0000b3","0000cc","0000e6","0000ff","1a1aff","3333ff","4d4dff" } },
            { "3333ff", new List<string>() {"0000e6","0000ff","1a1aff","3333ff","4d4dff","6666ff","8080ff" } },
            { "333399", new List<string>() {"202060","262673","2d2d86","333399","3939ac","4040bf","5353c6" } },
            { "669999", new List<string>() {"476b6b","527a7a","5c8a8a","669999","75a3a3","85adad","94b8b8" } },
            { "009999", new List<string>() {"004d4d","006666","008080","009999","00b3b3","00cccc","00e6e6" } },
            { "33cccc", new List<string>() {"248f8f","29a3a3","2eb8b8","33cccc","47d1d1","5cd6d6","70dbdb" } },
            { "00ccff", new List<string>() {"008fb3","00a3cc","00b8e6","00ccff","1ad1ff","33d6ff","4ddbff" } },
            { "0099ff", new List<string>() {"006bb3","007acc","008ae6","0099ff","1aa3ff","33adff","4db8ff" } },
            { "0066ff", new List<string>() {"0047b3","0052cc","005ce6","0066ff","1a75ff","3385ff","4d94ff" } },
            { "3366ff", new List<string>() {"0039e6","0040ff","1a53ff","3366ff","4d79ff","668cff","809fff" } },
            { "3333cc", new List<string>() {"24248f","2929a3","2e2eb8","3333cc","4747d1","5c5cd6","7070db" } },
            { "666699", new List<string>() {"47476b","52527a","5c5c8a","666699","7575a3","8585ad","9494b8" } },
            { "339966", new List<string>() {"206040","26734d","2d8659","339966","39ac73","40bf80","53c68c" } },
            { "00cc99", new List<string>() {"008060","009973","00b386","00cc99","00e6ac","00ffbf","1affc6" } },
            { "00ffcc", new List<string>() {"00b38f","00cca3","00e6b8","00ffcc","1affd1","33ffd6","4dffdb" } },
            { "00ffff", new List<string>() {"00b3b3","00cccc","00e6e6","00ffff","1affff","33ffff","4dffff" } },
            { "33ccff", new List<string>() {"00ace6","00bfff","1ac6ff","33ccff","4dd2ff","66d9ff","80dfff" } },
            { "3399ff", new List<string>() {"0073e6","0080ff","1a8cff","3399ff","4da6ff","66b3ff","80bfff" } },
            { "6699ff", new List<string>() {"1a66ff","3377ff","4d88ff","6699ff","80aaff","99bbff","b3ccff" } },
            { "6666ff", new List<string>() {"1a1aff","3333ff","4d4dff","6666ff","8080ff","9999ff","b3b3ff" } },
            { "6600ff", new List<string>() {"4700b3","5200cc","5c00e6","6600ff","751aff","8533ff","944dff" } },
            { "6600cc", new List<string>() {"400080","4c0099","5900b3","6600cc","7300e6","8000ff","8c1aff" } },
            { "339933", new List<string>() {"206020","267326","2d862d","339933","39ac39","40bf40","53c653" } },
            { "00cc66", new List<string>() {"008040","00994d","00b359","00cc66","00e673","00ff80","1aff8c" } },
            { "00ff99", new List<string>() {"00b36b","00cc7a","00e68a","00ff99","1affa3","33ffad","4dffb8" } },
            { "66ffcc", new List<string>() {"1affb3","33ffbb","4dffc4","66ffcc","80ffd5","99ffdd","b3ffe6" } },
            { "66ffff", new List<string>() {"1affff","33ffff","4dffff","66ffff","80ffff","99ffff","b3ffff" } },
            { "66ccff", new List<string>() {"1ab3ff","33bbff","4dc4ff","66ccff","80d5ff","99ddff","b3e6ff" } },
            { "99ccff", new List<string>() {"4da6ff","66b3ff","80bfff","99ccff","b3d9ff","cce6ff","e6f2ff" } },
            { "9999ff", new List<string>() {"4d4dff","6666ff","8080ff","9999ff","b3b3ff","ccccff","e6e6ff" } },
            { "9966ff", new List<string>() {"661aff","7733ff","884dff","9966ff","aa80ff","bb99ff","ccb3ff" } },
            { "9933ff", new List<string>() {"7300e6","8000ff","8c1aff","9933ff","a64dff","b366ff","bf80ff" } },
            { "9900ff", new List<string>() {"6b00b3","7a00cc","8a00e6","9900ff","a31aff","ad33ff","b84dff" } },
            { "006600", new List<string>() {"001a00","003300","004d00","006600","008000","009900","00b300" } },
            { "00cc00", new List<string>() {"008000","009900","00b300","00cc00","00e600","00ff00","1aff1a" } },
            { "00ff00", new List<string>() {"00b300","00cc00","00e600","00ff00","1aff1a","33ff33","4dff4d" } },
            { "66ff99", new List<string>() {"1aff66","33ff77","4dff88","66ff99","80ffaa","99ffbb","b3ffcc" } },
            { "99ffcc", new List<string>() {"4dffa6","66ffb3","80ffbf","99ffcc","b3ffd9","ccffe6","e6fff2" } },
            { "ccffff", new List<string>() {"80ffff","99ffff","b3ffff","ccffff","e6ffff","ffffff","ffffff" } },
            { "ccccff", new List<string>() {"8080ff","9999ff","b3b3ff","ccccff","e6e6ff","ffffff","ffffff" } },
            { "cc99ff", new List<string>() {"a64dff","b366ff","bf80ff","cc99ff","d9b3ff","e6ccff","f2e6ff" } },
            { "cc66ff", new List<string>() {"b31aff","bb33ff","c44dff","cc66ff","d580ff","dd99ff","e6b3ff" } },
            { "cc33ff", new List<string>() {"ac00e6","bf00ff","c61aff","cc33ff","d24dff","d966ff","df80ff" } },
            { "cc00ff", new List<string>() {"8f00b3","a300cc","b800e6","cc00ff","d11aff","d633ff","db4dff" } },
            { "9900cc", new List<string>() {"600080","730099","8600b3","9900cc","ac00e6","bf00ff","c61aff" } },
            { "003300", new List<string>() {"000000","000000","001a00","003300","004d00","006600","008000" } },
            { "009933", new List<string>() {"004d1a","006622","00802b","009933","00b33c","00cc44","00e64d" } },
            { "33cc33", new List<string>() {"248f24","29a329","2eb82e","33cc33","47d147","5cd65c","70db70" } },
            { "66ff66", new List<string>() {"1aff1a","33ff33","4dff4d","66ff66","80ff80","99ff99","b3ffb3" } },
            { "99ff99", new List<string>() {"4dff4d","66ff66","80ff80","99ff99","b3ffb3","ccffcc","e6ffe6" } },
            { "ccffcc", new List<string>() {"80ff80","99ff99","b3ffb3","ccffcc","e6ffe6","ffffff","ffffff" } },
            { "ffffff", new List<string>() {"d9d9d9","e6e6e6","f2f2f2","ffffff","ffffff","ffffff","ffffff" } },
            { "ffccff", new List<string>() {"ff80ff","ff99ff","ffb3ff","ffccff","ffe6ff","ffffff","ffffff" } },
            { "ff99ff", new List<string>() {"ff4dff","ff66ff","ff80ff","ff99ff","ffb3ff","ffccff","ffe6ff" } },
            { "ff66ff", new List<string>() {"ff1aff","ff33ff","ff4dff","ff66ff","ff80ff","ff99ff","ffb3ff" } },
            { "ff00ff", new List<string>() {"b300b3","cc00cc","e600e6","ff00ff","ff1aff","ff33ff","ff4dff" } },
            { "cc00cc", new List<string>() {"800080","990099","b300b3","cc00cc","e600e6","ff00ff","ff1aff" } },
            { "660066", new List<string>() {"1a001a","330033","4d004d","660066","800080","990099","b300b3" } },
            { "333300", new List<string>() {"000000","000000","1a1a00","333300","4d4d00","666600","808000" } },
            { "009900", new List<string>() {"004d00","006600","008000","009900","00b300","00cc00","00e600" } },
            { "66ff33", new List<string>() {"39e600","40ff00","53ff1a","66ff33","79ff4d","8cff66","9fff80" } },
            { "99ff66", new List<string>() {"66ff1a","77ff33","88ff4d","99ff66","aaff80","bbff99","ccffb3" } },
            { "ccff99", new List<string>() {"a6ff4d","b3ff66","bfff80","ccff99","d9ffb3","e6ffcc","f2ffe6" } },
            { "ffffcc", new List<string>() {"ffff80","ffff99","ffffb3","ffffcc","ffffe6","ffffff","ffffff" } },
            { "ffcccc", new List<string>() {"ff8080","ff9999","ffb3b3","ffcccc","ffe6e6","ffffff","ffffff" } },
            { "ff99cc", new List<string>() {"ff4da6","ff66b3","ff80bf","ff99cc","ffb3d9","ffcce6","ffe6f2" } },
            { "ff66cc", new List<string>() {"ff1ab3","ff33bb","ff4dc4","ff66cc","ff80d5","ff99dd","ffb3e6" } },
            { "ff33cc", new List<string>() {"e600ac","ff00bf","ff1ac6","ff33cc","ff4dd2","ff66d9","ff80df" } },
            { "cc0099", new List<string>() {"800060","990073","b30086","cc0099","e600ac","ff00bf","ff1ac6" } },
            { "993399", new List<string>() {"602060","732673","862d86","993399","ac39ac","bf40bf","c653c6" } },
            { "336600", new List<string>() {"0d1a00","1a3300","264d00","336600","408000","4d9900","59b300" } },
            { "669900", new List<string>() {"334d00","446600","558000","669900","77b300","88cc00","99e600" } },
            { "99ff33", new List<string>() {"73e600","80ff00","8cff1a","99ff33","a6ff4d","b3ff66","bfff80" } },
            { "ccff66", new List<string>() {"b3ff1a","bbff33","c4ff4d","ccff66","d5ff80","ddff99","e6ffb3" } },
            { "ffff99", new List<string>() {"ffff4d","ffff66","ffff80","ffff99","ffffb3","ffffcc","ffffe6" } },
            { "ffcc99", new List<string>() {"ffa64d","ffb366","ffbf80","ffcc99","ffd9b3","ffe6cc","fff2e6" } },
            { "ff9999", new List<string>() {"ff4d4d","ff6666","ff8080","ff9999","ffb3b3","ffcccc","ffe6e6" } },
            { "ff6699", new List<string>() {"ff1a66","ff3377","ff4d88","ff6699","ff80aa","ff99bb","ffb3cc" } },
            { "ff3399", new List<string>() {"e60073","ff0080","ff1a8c","ff3399","ff4da6","ff66b3","ff80bf" } },
            { "cc3399", new List<string>() {"8f246b","a3297a","b82e8a","cc3399","d147a3","d65cad","db70b8" } },
            { "990099", new List<string>() {"4d004d","660066","800080","990099","b300b3","cc00cc","e600e6" } },
            { "666633", new List<string>() {"33331a","444422","55552b","666633","77773c","888844","99994d" } },
            { "99cc00", new List<string>() {"608000","739900","86b300","99cc00","ace600","bfff00","c6ff1a" } },
            { "ccff33", new List<string>() {"ace600","bfff00","c6ff1a","ccff33","d2ff4d","d9ff66","dfff80" } },
            { "ffff66", new List<string>() {"ffff1a","ffff33","ffff4d","ffff66","ffff80","ffff99","ffffb3" } },
            { "ffcc66", new List<string>() {"ffb31a","ffbb33","ffc44d","ffcc66","ffd580","ffdd99","ffe6b3" } },
            { "ff9966", new List<string>() {"ff661a","ff7733","ff884d","ff9966","ffaa80","ffbb99","ffccb3" } },
            { "ff6666", new List<string>() {"ff1a1a","ff3333","ff4d4d","ff6666","ff8080","ff9999","ffb3b3" } },
            { "ff0066", new List<string>() {"b30047","cc0052","e6005c","ff0066","ff1a75","ff3385","ff4d94" } },
            { "d60094", new List<string>() {"8a005f","a30071","bd0082","d60094","f000a6","ff0ab3","ff24bb" } },
            { "993366", new List<string>() {"602040","73264d","862d59","993366","ac3973","bf4080","c6538c" } },
            { "a58800", new List<string>() {"594900","725e00","8c7300","a58800","bf9d00","d8b200","f2c700" } },
            { "cccc00", new List<string>() {"808000","999900","b3b300","cccc00","e6e600","ffff00","ffff1a" } },
            { "ffff00", new List<string>() {"b3b300","cccc00","e6e600","ffff00","ffff1a","ffff33","ffff4d" } },
            { "ffcc00", new List<string>() {"b38f00","cca300","e6b800","ffcc00","ffd11a","ffd633","ffdb4d" } },
            { "ff9933", new List<string>() {"e67300","ff8000","ff8c1a","ff9933","ffa64d","ffb366","ffbf80" } },
            { "ff6600", new List<string>() {"b34700","cc5200","e65c00","ff6600","ff751a","ff8533","ff944d" } },
            { "ff0033", new List<string>() {"b30024","cc0029","e6002e","ff0033","ff1a47","ff335c","ff4d70" } },
            { "cc0066", new List<string>() {"800040","99004d","b30059","cc0066","e60073","ff0080","ff1a8c" } },
            { "660033", new List<string>() {"1a000d","33001a","4d0026","660033","800040","99004d","b30059" } },
            { "996633", new List<string>() {"604020","734d26","86592d","996633","ac7339","bf8040","c68c53" } },
            { "cc9900", new List<string>() {"806000","997300","b38600","cc9900","e6ac00","ffbf00","ffc61a" } },
            { "ff9900", new List<string>() {"b36b00","cc7a00","e68a00","ff9900","ffa31a","ffad33","ffb84d" } },
            { "cc6600", new List<string>() {"804000","994d00","b35900","cc6600","e67300","ff8000","ff8c1a" } },
            { "ff3300", new List<string>() {"b32400","cc2900","e62e00","ff3300","ff471a","ff5c33","ff704d" } },
            { "ff0000", new List<string>() {"b30000","cc0000","e60000","ff0000","ff1a1a","ff3333","ff4d4d" } },
            { "cc0000", new List<string>() {"800000","990000","b30000","cc0000","e60000","ff0000","ff1a1a" } },
            { "990033", new List<string>() {"4d001a","660022","80002a","990033","b3003b","cc0044","e6004c" } },
            { "663300", new List<string>() {"1a0d00","331a00","4d2600","663300","804000","994d00","b35900" } },
            { "996600", new List<string>() {"4d3300","664400","805500","996600","b37700","cc8800","e69900" } },
            { "cc3300", new List<string>() {"802000","992600","b32d00","cc3300","e63900","ff4000","ff531a" } },
            { "993300", new List<string>() {"4d1a00","662200","802b00","993300","b33c00","cc4400","e64d00" } },
            { "990000", new List<string>() {"4d0000","660000","800000","990000","b30000","cc0000","e60000" } },
            { "800000", new List<string>() {"340000","4d0000","670000","800000","9a0000","b30000","cd0000" } },
            { "993333", new List<string>() {"602020","732626","862d2d","993333","ac3939","bf4040","c65353" } },
            { "ebebeb", new List<string>() {"c5c5c5","d2d2d2","dedede","ebebeb","f8f8f8","ffffff","ffffff" } },
            { "d7d7d7", new List<string>() {"b1b1b1","bebebe","cacaca","d7d7d7","e4e4e4","f1f1f1","fdfdfd" } },
            { "c3c3c3", new List<string>() {"9d9d9d","aaaaaa","b6b6b6","c3c3c3","d0d0d0","dddddd","e9e9e9" } },
            { "afafaf", new List<string>() {"898989","969696","a2a2a2","afafaf","bcbcbc","c9c9c9","d5d5d5" } },
            { "9b9b9b", new List<string>() {"757575","828282","8e8e8e","9b9b9b","a8a8a8","b5b5b5","c1c1c1" } },
            { "878787", new List<string>() {"616161","6e6e6e","7a7a7a","878787","949494","a1a1a1","adadad" } },
            { "737373", new List<string>() {"4d4d4d","5a5a5a","666666","737373","808080","8d8d8d","999999" } },
            { "5f5f5f", new List<string>() {"393939","464646","525252","5f5f5f","6c6c6c","797979","858585" } },
            { "4b4b4b", new List<string>() {"252525","323232","3e3e3e","4b4b4b","585858","656565","717171" } },
            { "373737", new List<string>() {"111111","1e1e1e","2a2a2a","373737","444444","515151","5d5d5d" } },
            { "232323", new List<string>() {"000000","0a0a0a","161616","232323","303030","3d3d3d","494949" } },
            { "0f0f0f", new List<string>() {"000000","000000","020202","0f0f0f","1c1c1c","292929","353535" } },
            { "f5f5f5", new List<string>() {"cfcfcf","dcdcdc","e8e8e8","f5f5f5","ffffff","ffffff","ffffff" } },
            { "e1e1e1", new List<string>() {"bbbbbb","c8c8c8","d4d4d4","e1e1e1","eeeeee","fbfbfb","ffffff" } },
            { "cdcdcd", new List<string>() {"a7a7a7","b4b4b4","c0c0c0","cdcdcd","dadada","e7e7e7","f3f3f3" } },
            { "b9b9b9", new List<string>() {"939393","a0a0a0","acacac","b9b9b9","c6c6c6","d3d3d3","dfdfdf" } },
            { "a5a5a5", new List<string>() {"7f7f7f","8c8c8c","989898","a5a5a5","b2b2b2","bfbfbf","cbcbcb" } },
            { "919191", new List<string>() {"6b6b6b","787878","848484","919191","9e9e9e","ababab","b7b7b7" } },
            { "7d7d7d", new List<string>() {"575757","646464","707070","7d7d7d","8a8a8a","979797","a3a3a3" } },
            { "696969", new List<string>() {"434343","505050","5c5c5c","696969","767676","838383","8f8f8f" } },
            { "555555", new List<string>() {"2f2f2f","3c3c3c","484848","555555","626262","6f6f6f","7b7b7b" } },
            { "414141", new List<string>() {"1b1b1b","282828","343434","414141","4e4e4e","5b5b5b","676767" } },
            { "2d2d2d", new List<string>() {"070707","141414","202020","2d2d2d","3a3a3a","474747","535353" } },
            { "191919", new List<string>() {"000000","000000","0c0c0c","191919","262626","333333","3f3f3f" } },
            { "050505", new List<string>() {"000000","000000","000000","050505","121212","1f1f1f","2b2b2b" } }
        };
    }
}
