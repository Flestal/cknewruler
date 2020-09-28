using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cknewruler
{
    class DNAGenerator
    {
        static int dnacur = 0;
        public static string GenerateDNA(string DNA,bool isFemale,bool write,DirectoryInfo dir,string folderName)
        {
            List<string> results = new List<string>();
            results.Clear();
            string encrypt = Base64Decode(DNA);
            string[] decrypt = encrypt.Select(c => Convert.ToString(c, 16)).ToArray();
            string dnastr = "";
            dnastr += folderName + "_dna_entry = {" + Environment.NewLine;
            dnastr += "portrait_info={" + Environment.NewLine;
            dnastr += "type = ";
            if (isFemale) { dnastr += "fe"; }
            dnastr += "male" + Environment.NewLine;
            dnastr += "genes={" + Environment.NewLine;
            dnastr += "hair_color={ " + dnaReturn(decrypt, true) + " " + dnaReturn(decrypt) + " " + dnaReturn(decrypt) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "skin_color={ " + dnaReturn(decrypt) + " " + dnaReturn(decrypt) + " " + dnaReturn(decrypt) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "eye_color={ " + dnaReturn(decrypt) + " " + dnaReturn(decrypt) + " " + dnaReturn(decrypt) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_chin_forward={ " + posneg(decrypt, "chin_forward") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "chin_forward") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_chin_height={ " + posneg(decrypt, "chin_height") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "chin_height") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_chin_width={ " + posneg(decrypt, "chin_width") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "chin_width") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_eye_angle={ " + posneg(decrypt, "eye_angle") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "eye_angle") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_eye_depth={ " + posneg(decrypt, "eye_depth") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "eye_depth") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_eye_height={ " + posneg(decrypt, "eye_height") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "eye_height") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_eye_distance={ " + posneg(decrypt, "eye_distance") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "eye_distance") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_eye_shut={ " + posneg(decrypt, "eye_shut") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "eye_shut") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_forehead_angle={ " + posneg(decrypt, "forehead_angle") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "forehead_angle") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_forehead_brow_height={ " + posneg(decrypt, "forehead_brow_height") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "forehead_brow_height") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_forehead_roundness={ " + posneg(decrypt, "forehead_roundness") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "forehead_roundness") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_forehead_width={ " + posneg(decrypt, "forehead_width") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "forehead_width") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_forehead_height={ " + posneg(decrypt, "forehead_height") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "forehead_height") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_head_height={ " + posneg(decrypt, "head_height") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "head_height") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_head_width={ " + posneg(decrypt, "head_width") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "head_width") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_head_profile={ " + posneg(decrypt, "head_profile") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "head_profile") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_head_top_height={ " + posneg(decrypt, "head_top_height") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "head_top_height") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_head_top_width={ " + posneg(decrypt, "head_top_width") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "head_top_width") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_jaw_angle={ " + posneg(decrypt, "jaw_angle") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "jaw_angle") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_jaw_forward={ " + posneg(decrypt, "jaw_forward") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "jaw_forward") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_jaw_height={ " + posneg(decrypt, "jaw_height") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "jaw_height") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_jaw_width={ " + posneg(decrypt, "jaw_width") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "jaw_width") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_mouth_corner_depth={ " + posneg(decrypt, "mouth_corner_depth") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "mouth_corner_depth") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_mouth_corner_height={ " + posneg(decrypt, "mouth_corner_height") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "mouth_corner_height") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_mouth_forward={ " + posneg(decrypt, "mouth_forward") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "mouth_forward") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_mouth_height={ " + posneg(decrypt, "mouth_height") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "mouth_height") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_mouth_width={ " + posneg(decrypt, "mouth_width") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "mouth_width") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_mouth_upper_lip_size={ " + posneg(decrypt, "mouth_upper_lip_size") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "mouth_upper_lip_size") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_mouth_lower_lip_size={ " + posneg(decrypt, "mouth_lower_lip_size") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "mouth_lower_lip_size") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_mouth_open={ " + posneg(decrypt, "mouth_open") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "mouth_open") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_neck_length={ " + posneg(decrypt, "neck_length") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "neck_length") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_neck_width={ " + posneg(decrypt, "neck_width") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "neck_width") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_cheek_forward={ " + posneg(decrypt, "cheek_forward") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "cheek_forward") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_cheek_height={ " + posneg(decrypt, "cheek_height") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "cheek_height") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_cheek_width={ " + posneg(decrypt, "cheek_width") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "cheek_width") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_ear_angle={ " + posneg(decrypt, "ear_angle") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "ear_angle") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("ear_inner_shape_pos");
            dnastr += "gene_bs_ear_inner_shape={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;

            results.Clear(); results.Add("ear_lower_bend_pos"); results.Add("ear_upper_bend_pos"); results.Add("ear_both_bend_pos");
            dnastr += "gene_bs_ear_bend={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;

            dnastr += "gene_bs_ear_outward={ " + posneg(decrypt, "ear_outward") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "ear_outward") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_ear_size={ " + posneg(decrypt, "ear_size") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "ear_size") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_eye_corner_depth={ " + posneg(decrypt, "eye_corner_depth") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "eye_corner_depth") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_eye_fold_shape={ " + posneg(decrypt, "eye_fold_shape") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "eye_fold_shape") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_eye_size={ " + posneg(decrypt, "eye_size") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "eye_size") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_eye_upper_lid_size={ " + posneg(decrypt, "eye_upper_lid_size") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "eye_upper_lid_size") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_forehead_brow_curve={ " + posneg(decrypt, "forehead_brow_curve") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "forehead_brow_curve") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_forehead_brow_forward={ " + posneg(decrypt, "forehead_brow_forward") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "forehead_brow_forward") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_forehead_brow_inner_height={ " + posneg(decrypt, "forehead_brow_inner_height") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "forehead_brow_inner_height") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_forehead_brow_outer_height={ " + posneg(decrypt, "forehead_brow_outer_height") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "forehead_brow_outer_height") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_forehead_brow_width={ " + posneg(decrypt, "forehead_brow_width") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "forehead_brow_width") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_jaw_def={ " + posneg(decrypt, "jaw_def") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "jaw_def") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("mouth_lower_lip_def_pos");
            dnastr += "gene_bs_mouth_lower_lip_def={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_mouth_lower_lip_full={ " + posneg(decrypt, "mouth_lower_lip_full") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "mouth_lower_lip_full") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_mouth_lower_lip_pad={ " + posneg(decrypt, "mouth_lower_lip_pad") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "mouth_lower_lip_pad") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_mouth_lower_lip_width={ " + posneg(decrypt, "mouth_lower_lip_width") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "mouth_lower_lip_width") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("mouth_philtrum_def_pos");
            dnastr += "gene_bs_mouth_philtrum_def={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_mouth_philtrum_shape={ " + posneg(decrypt, "mouth_philtrum_shape") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "mouth_philtrum_shape") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_mouth_philtrum_width={ " + posneg(decrypt, "mouth_philtrum_width") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "mouth_philtrum_width") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("mouth_upper_lip_def_pos");
            dnastr += "gene_bs_mouth_upper_lip_def={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_mouth_upper_lip_full={ " + posneg(decrypt, "mouth_upper_lip_full") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "mouth_upper_lip_full") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_mouth_upper_lip_profile={ " + posneg(decrypt, "mouth_upper_lip_profile") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "mouth_upper_lip_profile") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_mouth_upper_lip_width={ " + posneg(decrypt, "mouth_upper_lip_width") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "mouth_upper_lip_width") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_nose_forward={ " + posneg(decrypt, "nose_forward") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "nose_forward") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_nose_height={ " + posneg(decrypt, "nose_height") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "nose_height") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_nose_length={ " + posneg(decrypt, "nose_length") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "nose_length") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_nose_nostril_height={ " + posneg(decrypt, "nose_nostril_height") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "nose_nostril_height") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_nose_nostril_width={ " + posneg(decrypt, "nose_nostril_width") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "nose_nostril_width") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("nose_profile_neg"); results.Add("nose_profile_pos"); results.Add("nose_profile_hawk"); results.Add("nose_profile_hawk_pos");
            dnastr += "gene_bs_nose_profile={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_nose_ridge_angle={ " + posneg(decrypt, "nose_ridge_angle") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "nose_ridge_angle") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_nose_ridge_width={ " + posneg(decrypt, "nose_ridge_width") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "nose_ridge_width") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_nose_size={ " + posneg(decrypt, "nose_size") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "nose_size") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_nose_tip_angle={ " + posneg(decrypt, "nose_tip_angle") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "nose_tip_angle") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_nose_tip_forward={ " + posneg(decrypt, "nose_tip_forward") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "nose_tip_forward") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "gene_bs_nose_tip_width={ " + posneg(decrypt, "nose_tip_width") + " " + dnaReturn(decrypt) + " " + posneg(decrypt, "nose_tip_width") + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("cheek_def_01"); results.Add("cheek_def_02");
            dnastr += "face_detail_cheek_def={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("cheek_fat_01_pos"); results.Add("cheek_fat_02_pos"); results.Add("cheek_fat_03_pos"); results.Add("cheek_fat_04_pos"); results.Add("cheek_fat_01_neg");
            dnastr += "face_detail_cheek_fat={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("chin_cleft"); results.Add("chin_dimple");
            dnastr += "face_detail_chin_cleft={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("chin_def");
            dnastr += "face_detail_chin_def={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("eye_lower_lid_def");
            dnastr += "face_detail_eye_lower_lid_def={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("eye_socket_01"); results.Add("eye_socket_02"); results.Add("eye_socket_03");
            dnastr += "face_detail_eye_socket={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("nasolabial_01"); results.Add("nasolabial_02"); results.Add("nasolabial_03"); results.Add("nasolabial_04");
            dnastr += "face_detail_nasolabial={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("nose_ridge_def_pos"); results.Add("nose_ridge_def_neg");
            dnastr += "face_detail_nose_ridge_def={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("nose_tip_def");
            dnastr += "face_detail_nose_tip_def={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("temple_def");
            dnastr += "face_detail_temple_def={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine; results.Clear(); results.Add("temple_def");
            results.Clear(); results.Add("brow_wrinkles_01"); results.Add("brow_wrinkles_02"); results.Add("brow_wrinkles_03"); results.Add("brow_wrinkles_04");
            dnastr += "expression_brow_wrinkles={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("eye_wrinkles_01"); results.Add("eye_wrinkles_02"); results.Add("eye_wrinkles_03");
            dnastr += "expression_eye_wrinkles={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("forehead_wrinkles_01"); results.Add("forehead_wrinkles_02"); results.Add("forehead_wrinkles_03");
            dnastr += "expression_forehead_wrinkles={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("cheek_wrinkles_left_01"); results.Add("cheek_wrinkles_right_01"); results.Add("cheek_wrinkles_both_01"); results.Add("nose_wrinkles_01");
            dnastr += "expression_other={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("complexion_1"); results.Add("complexion_2"); results.Add("complexion_3"); results.Add("complexion_4"); results.Add("complexion_5"); results.Add("complexion_6"); results.Add("complexion_7"); results.Add("complexion_beauty_1"); results.Add("complexion_ugly_1"); results.Add("complexion_no_face");
            dnastr += "complexion={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("full_height"); results.Add("normal_height"); results.Add("dwarf_height"); results.Add("giant_height");
            dnastr += "gene_height={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("body_average"); results.Add("body_fat_head_fat_low"); results.Add("body_fat_head_fat_medium"); results.Add("body_fat_head_fat_full"); results.Add("no_portrait");
            dnastr += "gene_bs_body_type={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("body_shape_average_clothed"); results.Add("body_shape_average"); results.Add("body_shape_apple_half"); results.Add("body_shape_apple_full"); results.Add("body_shape_hourglass_half"); results.Add("body_shape_hourglass_full"); results.Add("body_shape_pear_half"); results.Add("body_shape_pear_full"); results.Add("body_shape_rectangle_half"); results.Add("body_shape_rectangle_full"); results.Add("body_shape_triangle_half"); results.Add("body_shape_triangle_full");
            dnastr += "gene_bs_body_shape={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("bust_clothes"); results.Add("bust_default"); results.Add("bust_shape_1_half"); results.Add("bust_shape_1_full"); results.Add("bust_shape_2_half"); results.Add("bust_shape_2_full"); results.Add("bust_shape_3_half"); results.Add("bust_shape_3_full"); results.Add("bust_shape_4_half"); results.Add("bust_shape_4_full");
            dnastr += "gene_bs_bust={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("old_1"); results.Add("old_2"); results.Add("old_3"); results.Add("old_4"); results.Add("old_beauty_1"); results.Add("no_aging");
            dnastr += "gene_age={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("no_eyebrows"); results.Add("avg_spacing_avg_thickness"); results.Add("avg_spacing_high_thickness"); results.Add("avg_spacing_low_thickness"); results.Add("avg_spacing_lower_thickness"); results.Add("far_spacing_avg_thickness"); results.Add("far_spacing_high_thickness"); results.Add("far_spacing_low_thickness"); results.Add("far_spacing_lower_thickness"); results.Add("close_spacing_avg_thickness"); results.Add("close_spacing_high_thickness"); results.Add("close_spacing_low_thickness"); results.Add("close_spacing_lower_thickness");
            dnastr += "gene_eyebrows_shape={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("no_eyebrows"); results.Add("layer_2_avg_thickness"); results.Add("layer_2_high_thickness"); results.Add("layer_2_low_thickness"); results.Add("layer_2_lower_thickness");
            dnastr += "gene_eyebrows_fullness={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("body_hair_sparse"); results.Add("body_hair_avg"); results.Add("body_hair_dense"); results.Add("body_hair_sparse_low_stubble"); results.Add("body_hair_avg_low_stubble"); results.Add("body_hair_dense_low_stubble");
            dnastr += "gene_body_hair={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("all_hairstyles"); results.Add("no_hairstyles"); results.Add("western_hairstyles"); results.Add("mena_hairstyles"); results.Add("byzantine_hairstyles"); results.Add("sub_saharan_hairstyles"); results.Add("rtt_hairstyles"); results.Add("indian_hairstyles"); results.Add("northern_hairstyles"); results.Add("steppe_hairstyles"); results.Add("catholic_devoted_hairstyles"); results.Add("western_baby_hairstyles"); results.Add("sub_saharan_baby_hairstyles");
            dnastr += "hairstyles={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("no_beard"); results.Add("all_beards"); results.Add("western_beards"); results.Add("rtt_beards"); results.Add("mena_beards"); results.Add("northern_beards"); results.Add("steppe_beards"); results.Add("sub_saharan_beards"); results.Add("indian_beards");
            dnastr += "beards={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("normal_eyes"); results.Add("normal_eyes_no_shadow"); results.Add("normal_eyes_dark_iris"); results.Add("normal_eyes_asian"); results.Add("bloodshot_eyes"); results.Add("blind_eyes"); results.Add("no_eyes");
            dnastr += "eye_accessory={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("normal_teeth"); results.Add("no_teeth");
            dnastr += "teeth_accessory={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            results.Clear(); results.Add("no_eyelashes"); results.Add("normal_eyelashes"); results.Add("asian_eyelashes");
            dnastr += "eyelashes_accessory={ " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " " + nonposneg(decrypt, results) + " " + dnaReturn(decrypt) + " }" + Environment.NewLine;
            dnastr += "pose ={ \"\" 255 \"\" 0 }" + Environment.NewLine + "clothes ={ \"northern_high_nobility_clothes\" 152 \"most_clothes\" 0 }" + Environment.NewLine + "headgear ={ \"western_high_nobility\" 152 \"no_headgear\" 0 }" + Environment.NewLine + "legwear ={ \"western_common_legwear\" 152 \"all_legwear\" 0 }" + Environment.NewLine;
            dnastr += "}" + Environment.NewLine + "}" + Environment.NewLine + "enabled=yes" + Environment.NewLine + "}";
            if (write) { File.WriteAllText(dir.ToString() + "\\" + folderName + "_dna.txt", dnastr, Encoding.UTF8); }
            else { return dnastr; }
            return "";
        }
        static string posneg(string[] decrypt, string head, bool initialize = false)
        {
            if (initialize)
            {
                dnacur = 0;
            }
            if (isPositive(decrypt) == 1)
            {
                return "\"" + head + "_pos\"";
            }
            else
            {
                return "\"" + head + "_neg\"";
            }
        }
        static string nonposneg(string[] decrypt, List<string> results, bool initialize = false)
        {
            if (initialize)
            {
                dnacur = 0;
            }
            try
            {
                return "\"" + results[isPositive(decrypt)] + "\"";
            }
            catch
            {
                return "\"" + results[results.Count - 1] + "\"";
            }

        }
        static int isPositive(string[] decrypt, bool initialize = false)
        {
            if (initialize)
            {
                dnacur = 0;
            }
            try
            {
                return Convert.ToInt32(decrypt[dnacur++], 16);
            }
            catch(Exception e)
            {
                return 0;
            }
        }
        public static string Base64Decode(string str)
        {
            return System.Text.Encoding.GetEncoding(65000).GetString(Convert.FromBase64String(str));
        }
        static string dnaReturn(string[] decrypt, bool initialize = false)
        {
            if (initialize)
            {
                dnacur = 0;
            }
            int value;
            try
            {
                value = Convert.ToInt32(decrypt[dnacur++], 16);
            }
            catch(Exception e)
            {
                value = 0;
            }
            return value.ToString();
        }
    }
}
