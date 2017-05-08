using HACS.Components;
using HACS.Core;
using System;
using System.Xml.Serialization;
using Utilities;

namespace CEGS_Aeon_Namespace
{
	public class CEGS_Aeon : CEGS
	{
		#region SystemComponents

		[XmlIgnore] public Meter m_V_5VMainsDetect;
		[XmlIgnore] public Meter m_p_Bakeout;

		[XmlIgnore] public Valve v_BP_GM;
		[XmlIgnore] public Valve v_d13C_CF;

		[XmlIgnore] public Valve v_LN_d13C;
		[XmlIgnore] public MeteringValve v_new_flow;

		[XmlIgnore] public TempSensor ts_LN_d13C;

		[XmlIgnore] public OnOffDevice air_d13C_FTC;

		[XmlIgnore] public FTColdfinger ftc_d13C;

		#endregion SystemComponents

		public CEGS_Aeon() : base()
		{	
			try
			{
				XmlSerializer = new XmlSerializer(typeof(CEGS_Aeon));
				//var writer = new System.IO.StreamWriter("format.xml", false);
				//XmlSerializer.Serialize(writer, this);
				//writer.Close();
			}
			catch (Exception e) { System.Windows.Forms.MessageBox.Show(e.ToString()); }
		}
		
		#region Startup and ShutDown

		#region System Components

		protected override void getSystemComponents()
		{
			base.getSystemComponents();

			m_V_5VMainsDetect = Meter.Find("m_V_5VMainsDetect");
			m_p_Bakeout = Meter.Find("m_p_Bakeout");

			v_BP_GM = Valve.Find("v_BP_GM");
			v_d13C_CF = Valve.Find("v_d13C_CF");
			v_LN_d13C = Valve.Find("v_LN_d13C");

			v_new_flow = Valve.Find("v_new_flow") as MeteringValve;

			ts_LN_d13C = TempSensor.Find("ts_LN_d13C");

			air_d13C_FTC = OnOffDevice.Find("air_d13C_FTC");

			ftc_d13C = FTColdfinger.Find("ftc_d13C");
		}

		#endregion System Components

		#region Constants

		IM_GM IM_GM = IM_GM.Default;

		#endregion Constants

		protected override void buildProcessDictionary()
		{
			ProcessDictionary.Add(ProcessNames.run_sample, run_sample);
			ProcessDictionary.Add(ProcessNames.enter_sample_data, enter_sample_data);
			ProcessDictionary.Add(ProcessNames.load_carbonate_sample, load_carbonate_sample);

			ProcessDictionary.Add(ProcessNames.prepare_GRs_for_service, prepare_GRs_for_service);
			ProcessDictionary.Add(ProcessNames.change_sulfur_Fe, change_sulfur_Fe);
			ProcessDictionary.Add(ProcessNames.precondition_GRs, precondition_GRs);

			ProcessDictionary.Add(ProcessNames.prepare_carbonate_sample, prepare_carbonate_sample);

			ProcessDictionary.Add(ProcessNames.open_line, open_line);
			ProcessDictionary.Add(ProcessNames.roughAndEvacuate, roughAndEvacuate);
			ProcessDictionary.Add(ProcessNames.evacuate_IM, evacuate_IM);
			ProcessDictionary.Add(ProcessNames.evacuate_VTT, evacuate_VTT);
			ProcessDictionary.Add(ProcessNames.evacuate_split, evacuate_split);
			ProcessDictionary.Add(ProcessNames.evacuate_GM, evacuate_GM);

			ProcessDictionary.Add(ProcessNames.prepare_new_vial, prepare_new_vial);

			ProcessDictionary.Add(ProcessNames.admitDeadCO2, admitDeadCO2);
			ProcessDictionary.Add(ProcessNames.admitSealedCO2IP, admitSealedCO2IP);
			ProcessDictionary.Add(ProcessNames.evacuate_IP, evacuate_IP);
			ProcessDictionary.Add(ProcessNames.clean_IM, clean_IM);
			ProcessDictionary.Add(ProcessNames.purge_IP, purge_IP);
			ProcessDictionary.Add(ProcessNames.admit_IP_O2, admit_IP_O2);
			ProcessDictionary.Add(ProcessNames.heat_quartz_open_line, heat_quartz_open_line);
			ProcessDictionary.Add(ProcessNames.turn_off_CC_furnaces, turn_off_CC_furnaces);
			ProcessDictionary.Add(ProcessNames.discard_IP_gases, discard_IP_gases);

			ProcessDictionary.Add(ProcessNames.isolate_sections, isolate_sections);
			ProcessDictionary.Add(ProcessNames.freeze_VTT, freeze_VTT);
			ProcessDictionary.Add(ProcessNames.evacuate_VTT_CuAg, evacuate_VTT_CuAg);
			ProcessDictionary.Add(ProcessNames.bleed_etc, bleed_etc);
			ProcessDictionary.Add(ProcessNames.bleed, bleed);
			ProcessDictionary.Add(ProcessNames.extract_etc, extract_etc);
			ProcessDictionary.Add(ProcessNames.extract, extract);
			ProcessDictionary.Add(ProcessNames.pressurize_VTT_MC, pressurize_VTT_MC);
			ProcessDictionary.Add(ProcessNames.measure_etc, measure_etc);
			ProcessDictionary.Add(ProcessNames.measure, measure);
			ProcessDictionary.Add(ProcessNames.refilter, refilter);
			ProcessDictionary.Add(ProcessNames.removeSulfur, removeSulfur);
			ProcessDictionary.Add(ProcessNames.transfer_CO2_MC_VTT, transfer_CO2_from_MC_to_VTT);
			ProcessDictionary.Add(ProcessNames.split, split);
			ProcessDictionary.Add(ProcessNames.discard_MC_gases, discard_MC_gases);
			ProcessDictionary.Add(ProcessNames.graphitize_etc, graphitize_etc);
			ProcessDictionary.Add(ProcessNames.dilute, dilute);
			ProcessDictionary.Add(ProcessNames.divide_aliquots, divide_aliquots);
			ProcessDictionary.Add(ProcessNames.graphitize_aliquots, graphitize_aliquots);
			ProcessDictionary.Add(ProcessNames.clean_CuAg, clean_CuAg);
			ProcessDictionary.Add(ProcessNames.add_d13C_He, add_d13C_He);
			ProcessDictionary.Add(ProcessNames.clean_VTT, clean_VTT);
			ProcessDictionary.Add(ProcessNames.wait_for_operator, wait_for_operator);

			ProcessDictionary.Add(ProcessNames.edit_process_sequences, edit_process_sequences);
			ProcessDictionary.Add(ProcessNames.exerciseAllValves, exerciseAllValves);
			ProcessDictionary.Add(ProcessNames.exercise_LN_tank_valves, exerciseLNValves);
			ProcessDictionary.Add(ProcessNames.measure_CO2_extraction_yield, measure_CO2_extraction_yield);
			ProcessDictionary.Add(ProcessNames.transfer_CO2_from_MC_to_IP, transfer_CO2_from_MC_to_IP);
			ProcessDictionary.Add(ProcessNames.transfer_CO2_from_GR_to_MC, transfer_CO2_from_GR_to_MC);
			ProcessDictionary.Add(ProcessNames.test, test);

			ProcessDictionary.Add(ProcessNames.initializeSystem, initializeSystem);
		}

		#endregion Startup and ShutDown

		#region Periodic system activities & maintenance

		#region Logging

		protected override void setLogHeaders()
		{
			base.setLogHeaders();

			// Adds p_Bakeout
			PLog.Header = "pAmbient\tpBakeout\tpIM\tpGM\tpForeline\tpVM";

			// Adds tFtcD13C
			FTCLog.Header = "tFtcGR1\ttFtcGR2\ttFtcGR3\ttFtcGR4\ttFtcGR5\ttFtcGR6" +
				"\ttFtcVTT\ttFtcCuAg\ttFtcMC\ttFtcD13C\ttFtcVP\ttLNTank";
		}

		// Adds p_Bakeout
		protected override void logPressureStatus()
		{
			if (Math.Abs(old_pIM - m_p_IM) > 2 ||
				Math.Abs(old_pGM - m_p_GM) > 2 ||
				PLog.ElapsedMilliseconds > 30000
				)
			{
				old_pIM = m_p_IM;
				old_pGM = m_p_GM;
				old_pVTT = m_p_VTT;
				PLog.Record(
					m_p_Ambient.Value.ToString("0.00") + "\t" +
					m_p_Bakeout.Value.ToString("0.00") + "\t" +
					old_pIM.ToString("0") + "\t" +
					old_pGM.ToString("0") + "\t" +
					m_p_Foreline.Value.ToString("0.000") + "\t" +
					p_VM.ToString("0.0e0")
				);
			}
		}

		// Adds tFtcD13C
		[XmlIgnore] public double old_td13CFTC;		
		protected override void logFTCStatus()
		{
			if (Math.Abs(old_tGRFTC[0] - ftc_GR[0].Temperature) > FTCmin ||
				Math.Abs(old_tGRFTC[1] - ftc_GR[1].Temperature) > FTCmin ||
				Math.Abs(old_tGRFTC[2] - ftc_GR[2].Temperature) > FTCmin ||
				Math.Abs(old_tGRFTC[3] - ftc_GR[3].Temperature) > FTCmin ||
				Math.Abs(old_tGRFTC[4] - ftc_GR[4].Temperature) > FTCmin ||
				Math.Abs(old_tGRFTC[5] - ftc_GR[5].Temperature) > FTCmin ||
				Math.Abs(old_tVTTFTC - ftc_VTT.Temperature) > FTCmin ||
				Math.Abs(old_tCuAgFTC - ftc_CuAg.Temperature) > FTCmin ||
				Math.Abs(old_tMCFTC - ftc_MC.Temperature) > FTCmin ||
				Math.Abs(old_td13CFTC - ftc_d13C.Temperature) > FTCmin ||
				Math.Abs(old_tVPFTC - ftc_VP.Temperature) > FTCmin ||
				Math.Abs(old_tLNTank - LN_Tank.LevelSensor.Temperature) > 2 ||
				FTCLog.ElapsedMilliseconds > 300000
				)
			{
				old_tGRFTC[0] = ftc_GR[0].Temperature;
				old_tGRFTC[1] = ftc_GR[1].Temperature;
				old_tGRFTC[2] = ftc_GR[2].Temperature;
				old_tGRFTC[3] = ftc_GR[3].Temperature;
				old_tGRFTC[4] = ftc_GR[4].Temperature;
				old_tGRFTC[5] = ftc_GR[5].Temperature;
				old_tVTTFTC = ftc_VTT.Temperature;
				old_tCuAgFTC = ftc_CuAg.Temperature;
				old_tMCFTC = ftc_MC.Temperature;
				old_td13CFTC = ftc_d13C.Temperature;
				old_tVPFTC = ftc_VP.Temperature;
				old_tLNTank = LN_Tank.LevelSensor.Temperature;

				FTCLog.Record(
					old_tGRFTC[0].ToString("0") + "\t" +
					old_tGRFTC[1].ToString("0") + "\t" +
					old_tGRFTC[2].ToString("0") + "\t" +
					old_tGRFTC[3].ToString("0") + "\t" +
					old_tGRFTC[4].ToString("0") + "\t" +
					old_tGRFTC[5].ToString("0") + "\t" +
					old_tVTTFTC.ToString("0") + "\t" +
					old_tCuAgFTC.ToString("0") + "\t" +
					old_tMCFTC.ToString("0") + "\t" +
					old_td13CFTC.ToString("0") + "\t" +
					old_tVPFTC.ToString("0") + "\t" +
					old_tLNTank.ToString("0")
				);
			}
		}

		#endregion Logging
		
		#region Pump management

		#endregion Pump management

		protected override void HandlePowerFailure()
		{
			if (EnableWatchdogs && Initialized && !PowerFailed)
			{
				if (m_V_5VMainsDetect < V_5VMainsDetect_min)
				{
					if (!PowerDownTimer.IsRunning)
					{
						PowerDownTimer.Restart();
						Alert("System Warning", "Mains Power is down");
					}
					else if (PowerDownTimer.ElapsedMilliseconds > milliseconds_power_down_max)
					{
						PowerFailed = true;
						Alert("System Failure", "Mains Power Failure");
						MessageHandler.Send("System Failure", "Mains Power Failure", Message.Type.Tell);
						ProcessThread.Abort();
						v_LV.Close();
						v_HV.Close();
						v_B.Close();
						pump_HV.TurnOff();
						v_IM_VM.Close();
						v_VTTR_VM.Close();
						v_split_VM.Close();
						v_GM_VM.Close();
						waitForActuatorController();
					}
				}
				else if (PowerDownTimer.IsRunning)
				{
					PowerDownTimer.Stop();
					PowerDownTimer.Reset();
					Alert("System Message", "Mains Power restored");
				}
			}
		}

		#endregion Periodic system activities & maintenance

		#region Process control

		#region System initialization

		protected override void startHVPump()
		{
			// Assumes v_HV and v_LV are closed
			ProcessStep.Start("Start HV Pump");

			while (ProcessStep.Elapsed.TotalSeconds < 120) // while ("pump_is_not_up")
			{
				v_B.Open();
				waitForActuatorController();

				// wait long enough for pressure to be sensed
				ProcessSubStep.Start("Check for foreline pressure indication");
				while (m_p_Foreline < pressure_max_backing &&
						ProcessSubStep.Elapsed.TotalMilliseconds < 2000)
					wait();
				ProcessSubStep.End();

				ProcessSubStep.Start("Wait for foreline pressure < " + pressure_max_backing.ToString("0.000") + " Torr");
				while (m_p_Foreline > pressure_max_backing)
					wait();
				ProcessSubStep.End();

				pump_HV.TurnOn();   // ignored if it is already on

				v_B.Close();
				waitForActuatorController();

				ProcessSubStep.Start("Wait 13 seconds");
				while (ProcessSubStep.Elapsed.TotalMilliseconds < 13000)
					wait();
				ProcessSubStep.End();
			}
			ProcessStep.End();
		}

		#endregion System initialization

		#region Valve operation

		protected override void exerciseAllValves()
		{
			ProcessStep.Start("Exercise all opened valves (except flow valves)");
			exerciseValve(v_B);
			exerciseValve(v_HV);
			exerciseValve(v_LV);

			// these valves admit gas when Opened
			//exerciseValve(v_O2_IM);
			//exerciseValve(v_He_IM);
			//exerciseValve(v_He_VTTL);
			//exerciseValve(v_He_GM);
			//exerciseValve(v_H2_GM);
			//exerciseValve(v_CO2_GM);

			exerciseValve(v_IM_VM);
			exerciseValve(v_VTTR_VM);
			exerciseValve(v_split_VM);
			exerciseValve(v_GM_VM);

			exerciseValve(v_IP_IM);
			exerciseValve(v_IM_VTTL);
			exerciseValve(v_VTTL_VTTR);
			exerciseValve(v_VTTR_CuAg);
			exerciseValve(v_CuAg_MC);
			exerciseValve(v_MC_MCU);
			exerciseValve(v_MC_MCL);
			exerciseValve(v_MC_split);
			exerciseValve(v_split_GM);
			foreach (Valve v in v_GR_GM)
				exerciseValve(v);
			//exerciseValve(v_BP_GM);
			exerciseValve(v_d13C_GM);
			exerciseValve(v_d13C_CF);
			exerciseValve(v_VP_d13C);

			//exerciseValve(v_VTT_flow);

			// these valves admit gas when Opened
			//exerciseValve(v_He_GM_flow);
			//exerciseValve(v_H2_GM_flow);
			//exerciseValve(v_CO2_GM_flow);

			// these valves dispense liquid nitrogen when Opened
			//exerciseValve(v_LN_VTT);
			//exerciseValve(v_LN_CuAg);
			//exerciseValve(v_LN_MC);
			//exerciseValve(v_LN_GR[0]);
			//exerciseValve(v_LN_GR[1]);
			//exerciseValve(v_LN_GR[2]);
			//exerciseValve(v_LN_GR[3]);
			//exerciseValve(v_LN_GR[4]);
			//exerciseValve(v_LN_GR[5]);
			//exerciseValve(v_LN_d13C);
			//exerciseValve(v_LN_drain);
			ProcessStep.End();
		}

		protected override void exerciseLNValves()
		{
			base.exerciseLNValves();
			exerciseLNValve(v_LN_d13C);
		}

		protected override void open_v_d13C_CF()
		{
			v_d13C_CF.Open();
		}

		protected override void close_v_d13C_CF()
		{
			v_d13C_CF.Close();
		}

		#endregion Valve operation

		#region Roughing and evacuating

		protected override void evacuate_section(sections section, double pressure)
		{
			ProcessSubStep.Start("Rough and evacuate section");
			v_HV.Close();   // usually already done

			// Make sure any pending actions for valves below are 
			// completed before commanding these actions
			waitForActuatorController();

			switch (section)
			{
				case sections.IM:
					v_VTTR_VM.Close();
					v_split_VM.Close();
					v_GM_VM.Close();

					v_O2_IM.Close();
					v_He_IM.Close();
					v_IM_VTTL.Close();

					v_IM_VM.Open();
					break;
				case sections.VTT:
					v_IM_VM.Close();
					v_split_VM.Close();
					v_GM_VM.Close();

					v_He_VTTL.Close();
					v_IM_VTTL.Close();
					v_VTTR_CuAg.Close();

					v_VTTR_VM.Open();
					break;
				case sections.split:
					v_IM_VM.Close();
					v_VTTR_VM.Close();
					v_GM_VM.Close();

					v_VTTR_CuAg.Close();
					v_split_GM.Close();

					v_split_VM.Open();
					break;
				case sections.GM:
					v_IM_VM.Close();
					v_VTTR_VM.Close();
					v_split_VM.Close();

					v_He_GM.Close();
					v_H2_GM.Close();
					v_CO2_GM.Close();
					v_split_GM.Close();

					v_GM_VM.Open();
					break;
				default:
					Alert("Software error!", "Unrecognized line section \"" + section + "\"");
					return;
			}
			roughAndEvacuate(pressure);
			ProcessSubStep.End();
		}

		#endregion Roughing and evacuating

		#region Joining and isolating sections

		protected override bool section_is_open(sections section)
		{
			switch (section)
			{
				case sections.IM:
					return
						v_IM_VM.isOpened;
				case sections.VTT:
					return
						v_VTTR_VM.isOpened &&
						v_VTTL_VTTR.isOpened &&
						v_VTT_flow.isOpened;
				case sections.split:
					return
						v_split_VM.isOpened &&
						v_MC_split.isOpened &&
						v_CuAg_MC.isOpened &&
						v_MC_MCU.isOpened &&
						v_MC_MCL.isOpened;
				case sections.GM:
					return
						v_GM_VM.isOpened &&
						ready_GRs_are_opened() &&
						/* v_BP_GM.isOpened && */
						v_d13C_GM.isOpened &&
						v_d13C_CF.isOpened &&
						(VP_should_be_closed() || v_VP_d13C.isOpened);
				default:
					return false;
			}
		}

		protected override void open_line()
		{
			ProcessStep.Start("Open line");
			if (VTT.Dirty) clean_VTT();

			ProcessSubStep.Start("Close gas supplies");
			v_O2_IM.Close();
			v_He_IM.Close();
			v_He_VTTL.Close();
			v_He_GM.Close();
			v_H2_GM.Close();
			v_CO2_GM.Close();

			// close gas flow valves
			v_He_GM_flow.Close();
			v_H2_GM_flow.Close();
			v_CO2_GM_flow.Close();
			waitForActuatorController();
			ProcessSubStep.End();

			bool vmOpened = v_HV.isOpened && v_B.isOpened &&
				p_VM <= pressure_foreline_empty;
			bool imOpened = section_is_open(sections.IM);
			bool vttOpened = section_is_open(sections.VTT);
			bool mcOpened = section_is_open(sections.split);
			bool gmOpened = section_is_open(sections.GM);

			if (vmOpened && imOpened && vttOpened && mcOpened && gmOpened &&
				v_IM_VTTL.isOpened &&
				v_VTTR_CuAg.isOpened &&
				v_MC_split.isOpened &&
				v_split_GM.isOpened)
				return; // nothing to do; line is already opened

			isolate_sections();

			// make sure the VM is empty
			if (!vmOpened) roughAndEvacuate(pressure_ok);

			if (!mcOpened)
			{
				evacuate_CuAg_split(pressure_ok);
				v_split_VM.Close();
			}

			if (!vttOpened)
			{
				ProcessSubStep.Start("Evacuate VTT");
				v_HV.Close();
				v_VTTR_VM.Open();
				rough();

				v_VTTL_VTTR.Open();
				v_VTT_flow.Open();
				roughAndEvacuate(pressure_ok);

				v_VTTR_VM.Close();
				ProcessSubStep.End();
			}

			if (!gmOpened)
			{
				ProcessSubStep.Start("Evacuate GM");

				// bool doBP = v_BP_GM.isClosed;
				bool doD13C = v_d13C_GM.isClosed || v_d13C_CF.isClosed;
				bool doVP = v_VP_d13C.isClosed && !VP_should_be_closed();
				bool doGRs = !ready_GRs_are_opened();
				bool doGM = v_GM_VM.isClosed;

				v_HV.Close();
				v_GM_VM.Open();

				if (/*doBP ||*/ doD13C || doVP)
				{
					close_all_GRs();
					if (doVP || doD13C)
					{
						// v_BP_GM.Close();
						if (doVP) v_VP_d13C.Open();
						v_d13C_CF.Open();
						v_d13C_GM.Open();
						roughAndEvacuate(pressure_ok);
						if (v_VP_d13C.isOpened) VP.State = LinePort.States.Prepared;
					}
					/*
					if (doBP)
					{
						v_HV.Close();
						v_d13C_GM.Close();
						v_BP_GM.Open();
						roughAndEvacuate(pressure_ok);
					}
					*/
				}
				if (doGRs)
				{
					v_HV.Close();
					// v_BP_GM.Close();
					v_d13C_GM.Close();
					open_ready_GRs();
					roughAndEvacuate();
				}
				if (doGM && !(/*doBP ||*/ doD13C || doVP || doGRs))
					roughAndEvacuate();
				open_ready_GRs();
				// v_BP_GM.Open();
				v_d13C_GM.Open();
				waitForActuatorController();
				waitFor_p_VM(pressure_ok);
				v_GM_VM.Close();
				ProcessSubStep.End();
			}

			// TODO: implement useIMO2forSample (i.e., don't close v_IP_IM);
			// add settings for that and IMContainsSample. useIMO2forSample is
			// needed for samples that with extraordinarily high O2 consumption
			// (like iron powder from iron artifacts, which take O2 by rusting
			// as well as by combusting the carbon).
			// Also, add controls and settings for combustion temperatures, set by
			// default when Sample.Type is selected.
			bool IMContainsSample = false;
			if (!imOpened)
			{
				if (!IMContainsSample)
				{
					ProcessSubStep.Start("Evacuate IM");
					v_HV.Close();
					v_IM_VM.Open();
					roughAndEvacuate(pressure_ok);
					// always leave v_IP_IM as-is
					ProcessSubStep.End();
				}
			}

			ProcessSubStep.Start("Join and evacuate all empty sections");
			waitForActuatorController();
			v_IM_VM.Open();
			v_GM_VM.Open();
			v_split_VM.Open();
			v_split_GM.Open();
			if (!VTT.Dirty)
			{
				v_VTTR_VM.Open();
				if (!IMContainsSample) v_IM_VTTL.Open();
				v_VTTR_CuAg.Open();
			}
			waitForActuatorController();

			ProcessSubStep.End();
			ProcessStep.End();
		}

		#endregion Joining and isolating sections

		#region Sample loading and preparation

		#endregion Sample loading and preparation

		#endregion Process control

		#region Chamber volume calibration routines

		protected override void admit_cal_gas(CalibrationVolume v0)
		{
			ProcessSubStep.Start("Evacuate volume calibration initial volume");
			if (v0 is IM_GM)
			{
				// the caller is responsible to open v_IP_IM if needed
				open_line();
				waitFor_p_VM(pressure_ok);
			}
			else
			{
				close_sections();
				v_CuAg_MC.Close();
				v_HV.Close();

				v_MC_MCU.Open();
				v_MC_MCL.Open();

				v_VP_d13C.Open();
				v_d13C_CF.Open();       // Aeon CEGS only
				v_d13C_GM.Open();
				open_ready_GRs();

				v_MC_split.Open();
				v_split_GM.Open();
				v_GM_VM.Open();
				roughAndEvacuate(pressure_ok);
			}
			while (ugCinMC > 0.5 || Math.Abs(ugCinMC.RoC) > 0.010) wait();
			zero_MC();


			ProcessSubStep.End();

			close_sections();
			if (v0 is IM_GM)
			{
				v_IP_IM.Close();
			}
			else
			{
				v_CuAg_MC.Close();
			}

			v_MC_MCL.Close();
			v_MC_MCU.Close();
			close_all_GRs();
			v_VP_d13C.Close();
			v_d13C_CF.Close();          // Aeon CEGS only
			v_d13C_GM.Close();
			// v_BP_GM.Close();            // Aeon CEGS only

			ProcessSubStep.Start("Admit He into calibration initial volume");
			clean_pressurize_GM(Gases.He, pressure_calibration);
			ProcessSubStep.End();
		}

		protected override void calibrate_all_volumes_from_MC(int repeats)
		{
			// the order is important; some calibrations depend on prior ones
			calibrate_volumes_MCL_MCU(repeats);
			calibrate_volumes_split_GM(repeats);
			calibrate_volumes_GR(repeats);
			calibrate_volumes_d13C_VP(repeats);
			calibrate_volumes_IM_CuAg(repeats);
			calibrate_volume_VM(repeats);
		}

		protected override void calibrate_volumes_d13C_VP(int repeats)
		{
			double[][] obs = daa(3, repeats);   // observations

			ProcessStep.Start("Calibrate volumes d13C..VP");

			SampleLog.Record("MC..GM, MC..d13C, MC..VP");
			for (int i = 0; i < repeats; i++)
			{
				admit_cal_gas(MC_GM);

				obs[0][i] = measure_volume();
				v_d13C_CF.Close();
				obs[1][i] = measure_volume(v_d13C_GM, v_VP_d13C);
				obs[2][i] = measure_volume(v_VP_d13C);

				SampleLog.Record(
					obs[0][i].ToString("0.0") + "\t" +
					obs[1][i].ToString("0.0") + "\t" +
					obs[2][i].ToString("0.0"));
			}
			open_line();

			double v0 = mL_MC + mL_split + mL_GM;
			mL_d13C = v1(v0, obs[0], obs[1]);

			v0 += mL_d13C;
			mL_VP = v1(v0, obs[1], obs[2]);

			ProcessStep.End();
		}

		// IP should have a CC tube, prepared as usual (beads, sugar, etc.), but with no sample
		void calibrate_volumes_IM_CuAg(int repeats)
		{
			double[][] obs = daa(5, repeats);   // observations

			ProcessStep.Start("Calibrate volumes IM..CuAg");

			evacuate_IP();  // make sure IP is empty
			open_line();

			SampleLog.Record("MC..GM, CuAg..GM, VTT..GM, IM..GM, IM..GM+IP");
			for (int i = 0; i < repeats; i++)
			{
				admit_cal_gas(MC_GM);

				// make sure the volumes to be measured are evacuated
				ProcessSubStep.Start("Evacuate IM..CuAg");
				v_IM_VTTL.Open();
				v_IP_IM.Open();
				v_VTT_flow.Open();
				v_VTTL_VTTR.Open();
				v_VTTR_CuAg.Open();
				v_HV.Close();
				v_IM_VM.Open();                 // Aeon CEGS only
				roughAndEvacuate(pressure_ok);
				ProcessSubStep.End();

				obs[0][i] = measure_volume();
				obs[1][i] = measure_volume(v_CuAg_MC, v_VTTR_CuAg);
				obs[2][i] = measure_volume(v_VTTR_CuAg, v_IM_VTTL);
				v_IP_IM.Close();
				obs[3][i] = measure_volume(v_IM_VTTL, v_IM_VM);
				obs[4][i] = measure_volume(v_IP_IM);

				SampleLog.Record(
					obs[0][i].ToString("0.0") + "\t" +
					obs[1][i].ToString("0.0") + "\t" +
					obs[2][i].ToString("0.0") + "\t" +
					obs[3][i].ToString("0.0") + "\t" +
					obs[4][i].ToString("0.0"));
			}
			open_line();

			double v0 = mL_MC + mL_split + mL_GM;
			mL_CuAg = v1(v0, obs[0], obs[1]);

			v0 += mL_CuAg;
			mL_VTT = v1(v0, obs[1], obs[2]);

			v0 += mL_VTT;
			mL_IM = v1(v0, obs[2], obs[3]);

			v0 += mL_IM;
			mL_IP = v1(v0, obs[3], obs[4]);

			ProcessStep.End();
		}

		protected override void calibrate_volume_VM(int repeats)
		{
			double[][] obs = daa(2, repeats);   // observations

			ProcessStep.Start("Calibrate volume VM");

			SampleLog.Record("IM..GM, IM..GM+VM");
			for (int i = 0; i < repeats; i++)
			{
				admit_cal_gas(IM_GM);

				// make sure the volume to be measured is evacuated
				ProcessSubStep.Start("Evacuate VM");
				roughAndEvacuate(pressure_ok);
				ProcessSubStep.End();

				obs[0][i] = measure_volume();
				obs[1][i] = measure_volume(v_split_VM, v_HV);

				SampleLog.Record(
					obs[0][i].ToString("0.0") + "\t" +
					obs[1][i].ToString("0.0"));
			}
			open_line();

			double v0 = mL_IM + mL_VTT + mL_CuAg + mL_MC + mL_split + mL_GM;
			mL_VM = v1(v0, obs[0], obs[1]);

			ProcessStep.End();
		}

		#endregion Chamber volume calibration routines

		#region Test functions

		protected override void test()
		{
			pressurize_VTT_MC();

			//v_IM_VTTL.Close();
			//v_VTTR_CuAg.Close();
			//v_IM_VM.Close();
			//v_VTTR_VM.Close();
			//v_GM_VM.Close();



			//Gases gas = (Gases)Enum.Parse(typeof(Gases), Sample.ID);
			//if (gas == Gases.CO2)
			//    admitDeadCO2();
			//else
			//    pressurize_GM(gas, Sample.micrograms);
			////pressurize_GM(Gases.H2, pressure_Fe_prep_H2);
			////calibrate_volumes_GR(repeats);
		}

		#endregion Test functions
	}
}
