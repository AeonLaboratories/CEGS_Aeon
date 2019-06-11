using HACS.Components;
using System;
using System.Xml.Serialization;

namespace ApplicationNamespace
{
	public class CEGS_Aeon : CEGS
	{
		#region Component Implementation

		protected override void Connect()
		{
			base.Connect();
            m_p_Bakeout = Meter.Find("m_p_Bakeout");

        }

		public CEGS_Aeon() : base()
		{
			//XmlSerializer = new XmlSerializer(typeof(CEGS_Aeon));
		}

		#endregion Component Implementation

		#region SystemComponents		
		[XmlIgnore] public Meter m_p_Bakeout;
		#endregion SystemComponents

		#region Process Management

		protected override void BuildProcessDictionary()
		{
			ProcessDictionary.Add("Run sample", runSample);        // this should be Run process sequence
			ProcessDictionary.Add("Enter sample data", enterSampleData);
			ProcessDictionary.Add("Load acidified carbonate sample_", loadCarbonateSample);

			ProcessDictionary.Add("Prepare GRs for new iron and desiccant", prepare_GRs_for_service);
			ProcessDictionary.Add("Replace iron in sulfur traps", change_sulfur_Fe);
			ProcessDictionary.Add("Precondition GR iron_", precondition_GRs);

			ProcessDictionary.Add("Prepare carbonate sample for acid_", prepareCarbonateSample);

			ProcessDictionary.Add("Open and evacuate line", openLine);
			ProcessDictionary.Add("Evacuate IM section", evacuateIM);
			ProcessDictionary.Add("Evacuate VTT section", evacuateVTT);
			ProcessDictionary.Add("Evacuate Split section", evacuateSplit);
			ProcessDictionary.Add("Evacuate GM section_", evacuateGM);

			ProcessDictionary.Add("Prepare new d13C vial_", prepareNewVial);

			ProcessDictionary.Add("Admit dead CO2", admitDeadCO2);
			ProcessDictionary.Add("Admit sealed CO2", admitSealedCO2IP);
			ProcessDictionary.Add("Evacuate Inlet Port", evacuateIP);
			ProcessDictionary.Add("Evacuate IM to clean pressure", clean_IM);
			ProcessDictionary.Add("Purge Inlet Port", purge_IP);
			ProcessDictionary.Add("Admit O2 into Inlet Port", admitIPO2);
			ProcessDictionary.Add("Heat Quartz and Open Line", heatQuartzOpenLine);
			ProcessDictionary.Add("Turn Off CC Furnaces", turnOffCCFurnaces);
			ProcessDictionary.Add("Discard IP gases_", discardIPGases);

			ProcessDictionary.Add("Isolate sections", isolateSections);
			ProcessDictionary.Add("Freeze VTT", freeze_VTT);
			ProcessDictionary.Add("Evacuate CuAg..VTT", evacuateVTT_CuAg);
			ProcessDictionary.Add("Bleed, etc.", bleed_etc);
			ProcessDictionary.Add("Bleed", bleed);
			ProcessDictionary.Add("Extract, etc.", extract_etc);
			ProcessDictionary.Add("Extract", extract);
			ProcessDictionary.Add("Pressurize VTT..MC with He", pressurizeVTT_MC);
			ProcessDictionary.Add("Measure, etc.", measure_etc);
			ProcessDictionary.Add("Measure", measure);
			ProcessDictionary.Add("Remove sulfur", removeSulfur);
			ProcessDictionary.Add("Transfer CO2 in MC to VTT", transferCO2FromMCToVTT);
			ProcessDictionary.Add("Discard excess CO2 by splits", split);
			ProcessDictionary.Add("Discard MC gases", discard_MC_gases);
			ProcessDictionary.Add("Graphitize, etc.", graphitize_etc);
			ProcessDictionary.Add("Dilute small sample", dilute);
			ProcessDictionary.Add("Divide sample into aliquots", divideAliquots);
			ProcessDictionary.Add("Graphitize aliquots", graphitizeAliquots);
			ProcessDictionary.Add("Clean CuAg", cleanCuAg);
			ProcessDictionary.Add("add_d13C_He", add_d13C_He);
			ProcessDictionary.Add("clean_VTT", clean_VTT);
			ProcessDictionary.Add("Wait for Operator_", waitForOperator);

			ProcessDictionary.Add("Edit CEGS Process Sequences", editProcessSequences);
			ProcessDictionary.Add("Exercise all Opened valves", exerciseAllValves);
			ProcessDictionary.Add("Exercise all LN Manifold valves", exerciseLNValves);
//			ProcessDictionary.Add("Measure CO2 extraction yield", measureCO2ExtractionYield);
			ProcessDictionary.Add("Transfer CO2 from MC to IP", transferCO2FromMCToIP);
			ProcessDictionary.Add("Transfer CO2 from last GR to MC", transferCO2FromGRToMC);
			ProcessDictionary.Add("Calibrate flow valves", calibrateFlowValves);
			ProcessDictionary.Add("Calibrate MC volume (KV in MCU)", calibrateVolumeMC);
			ProcessDictionary.Add("Calibrate all volumes from MC", calibrateAllVolumesFromMC);
			ProcessDictionary.Add("Calibrate d13C He pressure", calibrate_d13C_He);
			ProcessDictionary.Add("Check GR H2 density ratios", calibrate_GR_H2);
			ProcessDictionary.Add("Test", test);

			base.BuildProcessDictionary();
		}
		
		#region Valve operation

		protected override void exerciseLNValves()
		{
			base.exerciseLNValves();
			//v_LN_drain.Exercise();
		}

		#endregion Valve operation

		#endregion Process Management

		#region Test functions

		protected override void test()
		{
			//VolumeCalibration.Find("MC").Calibrate();

			var g = GasSupply.Find(Sample.ID);
			g.Pressurize(Sample.milligrams);

			//pressurizeVTT_MC();
		}

		#endregion Test functions
	}
}