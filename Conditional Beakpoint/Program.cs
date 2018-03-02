﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Conditional_Beakpoint
    {
    class Program
        {
        static void Main (string[] args)
            {
            List<int> numbers = new List<int> { 4660, 38692, 1655, 62747, 30999, 18569, 27456, 44238, 30766, 45009, 56060, 2901, 29282, 61961, 24663, 39317, 14211, 2402, 40141, 42899, 51706, 14459, 64651, 1839, 28361, 43896, 19936, 29277, 6370, 29780, 46642, 55268, 1546, 35148, 34260, 5641, 31227, 31186, 56170, 28779, 24752, 53184, 15575, 11457, 24097, 39051, 42681, 49849, 54937, 52515, 1040, 8966, 15536, 34092, 5963, 55735, 39576, 51677, 34386, 52638, 64167, 63714, 37868, 986, 63901, 791, 1354, 59668, 27701, 19021, 8089, 48559, 11767, 11361, 18146, 64056, 64419, 53194, 56950, 54844, 1215, 35622, 39874, 19389, 28740, 37676, 39732, 32988, 29185, 44059, 31600, 45085, 62334, 3532, 30147, 26573, 15316, 14589, 13090, 23306, 37696, 48548, 22148, 35915, 44426, 18015, 62733, 4174, 15945, 7442, 56851, 51916, 60261, 45076, 51422, 28545, 23839, 18478, 37780, 26224, 26593, 33901, 30482, 49176, 52955, 28539, 51759, 8235, 46749, 57108, 48739, 49830, 40104, 33643, 17148, 18202, 13473, 3959, 40498, 10725, 40478, 35557, 17042, 21743, 52743, 45219, 50358, 17258, 17644, 1601, 2733, 62372, 42343, 52400, 62247, 3794, 18065, 38506, 48495, 15886, 31790, 54497, 22960, 24371, 24238, 7020, 11812, 26618, 27927, 33220, 15071, 19879, 43515, 27055, 51281, 56570, 16858, 8739, 61967, 7736, 43716, 34501, 56126, 45148, 54375, 51901, 7486, 53238, 36931, 13353, 137, 40502, 20999, 24611, 44469, 51516, 12597, 58205, 63040, 45722, 33406, 23740, 54865, 49959, 52064, 48389, 18856, 15287, 1119, 5677, 52471, 9325, 42073, 40758, 37705, 62823, 63905, 43347, 35531, 37871, 65069, 24108, 55221, 14574, 33083, 40104, 64415, 18904, 48120, 65299, 43973, 24187, 11234, 16245, 39864, 19976, 45171, 6167, 58618, 5985, 33044, 57733, 52119, 31253, 26417, 56346, 63963, 45775, 52441, 47181, 53145, 34785, 22673, 25168, 46188, 9297, 34053, 40291, 16875, 11960, 49508, 65487, 32702, 1354, 27239, 28283, 63625, 25828, 893, 17728, 17652, 57738, 50263, 29546, 4826, 7335, 37523, 23968, 53691, 42271, 41675, 18639, 31997, 939, 12153, 9187, 1513, 51601, 35591, 30567, 51458, 4879, 54826, 46658, 22012, 33092, 25031, 50765, 4014, 63668, 58255, 38135, 44881, 34712, 29528, 60942, 50056, 58662, 20341, 38853, 37309, 10084, 52134, 40139, 35819, 30868, 33489, 31762, 54735, 18051, 26770, 12024, 55771, 35861, 31805, 12772, 2912, 3605, 7533, 37269, 47838, 52293, 19953, 55558, 49551, 3540, 39293, 62820, 36946, 16746, 24666, 8385, 31259, 62273, 58793, 41373, 18280, 14687, 10838, 56678, 65137, 58804, 61565, 51498, 36898, 46230, 47898, 9019, 2907, 16755, 58029, 46450, 51128, 48607, 56549, 50551, 55666, 62111, 56123, 32278, 57110, 36204, 60351, 37988, 58920, 18384, 46300, 59032, 42603, 55967, 60027, 53760, 58302, 16390, 37667, 54569, 56262, 33990, 18659, 3320, 21176, 30273, 59912, 20190, 24251, 43750, 22791, 48187, 5724, 8241, 51241, 21703, 24099, 44094, 65102, 28932, 63988, 23576, 58113, 18514, 65464, 54400, 31951, 12475, 22262, 4269, 53683, 34738, 10939, 1980, 59823, 21676, 43451, 52802, 11102, 26837, 41826, 40160, 13736, 15169, 61127, 63648, 53308, 34361, 4725, 38324, 29660, 14207, 16822, 8734, 56115, 32686, 41412, 145, 3390, 32311, 63857, 47437, 63462, 19981, 55602, 53588, 37247, 3743, 13953, 29565, 43787, 36831, 32992, 38265, 52641, 23827, 9840, 42943, 22921, 1816, 1091, 63124, 7749, 49473, 40144, 39475, 17915, 2205, 11399, 27137, 45799, 43305, 49411, 44325, 28514, 59924, 42232, 59289, 25101, 7539, 26400, 49564, 20407, 40695, 60071, 58364, 46750, 44091, 21628, 32287, 22846, 64003, 42759, 1574, 31219, 732, 39687, 13989, 45372, 16127, 35672, 35042, 57879, 52351, 49301, 481, 52955, 54201, 9750, 58251, 47130, 16085, 17842, 15382, 40950, 17062, 42716, 32589, 54937, 47315, 58259, 39358, 46111, 44646, 4290, 47331, 546, 47836, 13106, 27782, 20236, 28243, 13916, 8973, 37401, 56893, 57220, 33591, 56929, 59590, 5408, 58083, 34340, 28911, 50692, 6760, 46160, 27377, 26159, 14157, 23550, 7097, 24586, 63592, 23402, 61848, 54465, 13233, 48060, 1969, 65470, 5118, 41094, 47503, 38015, 18887, 2168, 8868, 43516, 1839, 25376, 9125, 41195, 60882, 41906, 175, 5017, 17200, 59488, 63065, 1170, 38704, 21677, 64484, 4231, 13138, 3656, 15859, 51105, 41087, 2428, 43987, 51065, 54959, 59654, 290, 16989, 52372, 56431, 31805, 4592, 37291, 49396, 42102, 54315, 14425, 31437, 29239, 21686, 23226, 56831, 37265, 19279, 50530, 799, 26766, 48975, 42145, 43271, 24876, 15230, 51844, 23297, 2428, 47163, 46924, 23594, 51771, 1227, 41616, 48721, 18180, 26303, 27683, 58472, 29413, 54843, 45110, 10169, 55341, 47236, 39951, 59707, 27879, 49791, 30697, 24708, 535, 54160, 32888, 16849, 40379, 9100, 31555, 16574, 18283, 13994, 46967, 60473, 7391, 56365, 45200, 28012, 45605, 40040, 38650, 10961, 57130, 57592, 36920, 37458, 3865, 31975, 53465, 43175, 40814, 57671, 60953, 18172, 16465, 22215, 23059, 63146, 33874, 24766, 8342, 9079, 60283, 11109, 40189, 15419, 7875, 50171, 2777, 64510, 2035, 11939, 14102, 53373, 11140, 19735, 33112, 8477, 17239, 60965, 12983, 8403, 21170, 53914, 41294, 26146, 18575, 28795, 44007, 50710, 33305, 47589, 59673, 20838, 31697, 29570, 16213, 46020, 17402, 21500, 29582, 19228, 29198, 54489, 41139, 28875, 43569, 7579, 7031, 62265, 54638, 14582, 45906, 38443, 11783, 65474, 53444, 6368, 35350, 14043, 62379, 44615, 6163, 17602, 31205, 19980, 17800, 58799, 21676, 47105, 3522, 52627, 56609, 61274, 31383, 59289, 44739, 32215, 12775, 12418, 48112, 10995, 21763, 47277, 61607, 18722, 1683, 21229, 9054, 31758, 41661, 9845, 10670, 3359, 24656, 50501, 13065, 11596, 23284, 21158, 11074, 50305, 51438, 25461, 58742, 2010, 23508, 50166, 7060, 18028, 20734, 21229, 59128, 22931, 31465, 51383, 22851, 24421, 21529, 12482, 18297, 62106, 49744, 55452, 5443, 59211, 41957, 53249, 36618, 46416, 46224, 33143, 8931, 57151, 1344, 63342, 25092, 61837, 54069, 59596, 60749, 17051, 14168, 56561, 11023, 20432, 16252, 53273, 37428, 38807, 27649, 54178, 55601, 10801, 2861, 14503, 560, 61520, 20017, 65066, 25588, 35793, 13548, 26179, 37339, 53126, 12297, 1976, 21587, 33658, 26291, 26549, 35886, 27467, 17267, 1246, 47937, 1839, 44429, 50546, 42959, 54218, 15821, 63345, 18767, 57580, 43076, 63665, 54290, 52375, 62781, 29106, 41819, 54538, 34008, 24956, 3502, 53524, 19221, 23432, 8134, 14275, 31686, 3769, 12516, 1099, 18292, 28133, 59068, 1615, 32100, 7377, 17091, 35005, 22106, 36904, 19972, 15738, 7412, 45293, 10049, 14167, 13221, 34746, 36412, 62719, 50264, 46883, 58994, 57846, 63278, 59948, 39496, 20996, 42412, 28684, 22532, 12051, 50828, 17667, 39288, 14943, 4596, 52675, 20275, 55403, 12015, 6814, 32432, 62639, 4984, 53298, 46112, 39463, 13383, 59502, 1053, 62474, 32892, 15332, 16370, 36943, 34674, 1222, 3871, 37687, 33416, 61630, 58127, 58956, 14371, 7921, 30445, 55280, 6004, 60641, 9570, 26081, 14471, 46543, 50704, 43450, 14450, 61889, 52862, 9979, 13836, 33, 7612, 48445, 27631, 25592, 44693, 35496, 1297, 2344, 45803, 3374, 48803, 48123, 21987, 15919, 14221, 39011, 48268, 62598, 22853, 56367, 33458 };
            for (int i = 0; i < numbers.Count; i++)
                {
                int values = numbers[i];
                Console.WriteLine ($"Index[{i}] - {values}");
                }
            Console.ReadKey ();
            }
        }
    }