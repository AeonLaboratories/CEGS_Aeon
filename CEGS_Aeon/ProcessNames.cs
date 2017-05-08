using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace CEGS_Aeon_Namespace
{
	public class ProcessNames
	{
		public static string open_line = "Open and evacuate line";
		public static string prepare_TF_for_opening = "Prepare TF for opening";
		public static string bakeout_TF = "Bakeout TF";
		public static string run_sample = "Run sample";
		public static string enter_sample_data = "Enter sample data";
		public static string load_carbonate_sample = "Load acidified carbonate sample_";

		public static string prepare_GRs_for_service = "Prepare GRs for new iron and desiccant";
		public static string change_sulfur_Fe = "Replace iron in sulfur traps";
		public static string precondition_GRs = "Precondition GR iron_";

		public static string prepare_carbonate_sample = "Prepare carbonate sample for acid_";

		public static string roughAndEvacuate = "Rough and evacuate";
		public static string evacuate_TF = "Evacuate TF";
		public static string evacuate_FC = "Evacuate FC section";
		public static string evacuate_IM = "Evacuate IM section";
		public static string evacuate_VTT = "Evacuate VTT section";
		public static string evacuate_split = "Evacuate split section";
		public static string evacuate_GM = "Evacuate GM section_";

		public static string prepare_new_vial = "Prepare new d13C vial_";

		public static string extract_TF = "Extract sample from tube furnace";
		public static string admitDeadCO2 = "Admit dead CO2";
		public static string admitSealedCO2IP = "Admit sealed CO2 at IP";
		public static string evacuate_IP = "Evacuate Inlet Port";
		public static string clean_IM = "Evacuate IM to clean pressure";
		public static string purge_IP = "Purge Inlet Port";
		public static string admit_IP_O2 = "Admit O2 into Inlet Port";
		public static string heat_quartz_open_line = "Heat Quartz and Open Line";
		public static string turn_off_CC_furnaces = "Turn Off CC Furnaces";
		public static string discard_IP_gases = "Discard IP gases_";

		public static string isolate_sections = "Isolate sections";
		public static string freeze_VTT = "Freeze VTT";
		public static string evacuate_VTT_CuAg = "Evacuate CuAg..VTT";
		public static string bleed_etc = "Bleed, etc.";
		public static string bleed = "Bleed";
		public static string extract_etc = "Extract, etc.";
		public static string pressurize_VTT_MC = "Pressurize VTT..MC with He";
		public static string extract = "Extract";
		public static string measure_etc = "Measure, etc.";
		public static string measure = "Measure";
		public static string refilter = "Refilter";
		public static string removeSulfur = "Remove sulfur";
		public static string transfer_CO2_MC_VTT = "Transfer CO2 in MC to VTT";
		public static string split = "Discard excess CO2 by splits";
		public static string discard_MC_gases = "Discard MC gases";
		public static string graphitize_etc = "Graphitize, etc.";
		public static string dilute = "Dilute small sample";
		public static string divide_aliquots = "Divide sample into aliquots";
		public static string graphitize_aliquots = "Graphitize aliquots";
		public static string clean_CuAg = "Clean CuAg";
		public static string add_d13C_He = "add_d13C_He";
		public static string clean_VTT = "clean_VTT";
		public static string wait_for_operator = "Wait for Operator_";

		public static string edit_process_sequences = "Edit Process Sequences";
		public static string exerciseAllValves = "Exercise all Opened valves";
		public static string exercise_LN_tank_valves = "Exercise all LN tank valves";
		public static string measure_CO2_extraction_yield = "Measure CO2 extraction yield";
		public static string transfer_CO2_from_MC_to_IP = "Transfer CO2 from MC to IP";
		public static string transfer_CO2_from_GR_to_MC = "Transfer CO2 from last GR to MC";
		public static string test = "Test";

		public static string initializeSystem = "Initialize System_";

		public static List<string> All
		{
			get
			{
				List<string> Ignored = new List<string>()
				{
					run_sample,
					enter_sample_data,
					initializeSystem
				};

				List<string> processes = new List<string>();
				FieldInfo[] fields = (typeof(ProcessNames)).GetFields();
				foreach (FieldInfo field in fields)
				{
					string p = (string)field.GetValue(null);
					if (!Ignored.Contains(p))
						processes.Add(p);
				}
				return processes;
			}
		}
	}
}
