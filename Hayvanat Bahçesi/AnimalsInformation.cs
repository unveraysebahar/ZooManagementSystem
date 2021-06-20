using Hayvanat_Bahçesi.Animal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hayvanat_Bahçesi
{
    public partial class AnimalsInformation : Form
    {
        public AnimalsInformation()
        {
            InitializeComponent();
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Leon leon = new Leon("Carnivore", "Africa" ,"Lungs", "Breed", "Cartilage and Bone", "Closed circulation", "Striped and smooth muscles");

            string clas = leon.Class();
            string inte = leon.InternalSkeletonStructureInfo();
            string circ = leon.CirculatorySystemTypeInfo();
            string musc = leon.MuscleTypeInfo();
            string brea = leon.BreathingPatternInfo();
            string prol = leon.FormOfProliferationInfo();
            string nutr = leon.Nutrition();
            string habi = leon.HabitatInfo();

            listBox1.Items.Add("LEON");
            listBox1.Items.Add("Class: " + clas);
            listBox1.Items.Add("Internal Skeleton Structure: " + leon.InternalSkeletonStructure);
            listBox1.Items.Add("Circulatory System Type: " + leon.CirculatorySystemType);
            listBox1.Items.Add("Muscle Type: " + leon.MuscleType);
            listBox1.Items.Add("Breathing Pattern: " + leon.BreathingPattern);
            listBox1.Items.Add("Form of Proliferation: " + leon.FormOfProliferation);
            listBox1.Items.Add("Nutrition Types: " + leon.NutritionTypes);
            listBox1.Items.Add("Habitat: " + leon.Habitat);
            listBox1.Items.Add(inte);
            listBox1.Items.Add(circ);
            listBox1.Items.Add(musc);
            listBox1.Items.Add(brea);
            listBox1.Items.Add(prol);
            listBox1.Items.Add(nutr);
            listBox1.Items.Add(habi);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Jaguar jagu = new Jaguar("Carnivore", "America", "Lungs", "Breed", "Cartilage and Bone", "Closed circulation", "Striped and smooth muscles");

            string clas = jagu.Class();
            string inte = jagu.InternalSkeletonStructureInfo();
            string circ = jagu.CirculatorySystemTypeInfo();
            string musc = jagu.MuscleTypeInfo();
            string brea = jagu.BreathingPatternInfo();
            string prol = jagu.FormOfProliferationInfo();
            string nutr = jagu.Nutrition();
            string habi = jagu.HabitatInfo();
            string swim = jagu.Swim();

            listBox1.Items.Add("JAGUAR");
            listBox1.Items.Add("Class: " + clas);
            listBox1.Items.Add("Internal Skeleton Structure: " + jagu.InternalSkeletonStructure);
            listBox1.Items.Add("Circulatory System Type: " + jagu.CirculatorySystemType);
            listBox1.Items.Add("Muscle Type: " + jagu.MuscleType);
            listBox1.Items.Add("Breathing Pattern: " + jagu.BreathingPattern);
            listBox1.Items.Add("Form of Proliferation: " + jagu.FormOfProliferation);
            listBox1.Items.Add("Nutrition Types: " + jagu.NutritionTypes);
            listBox1.Items.Add("Habitat: " + jagu.Habitat);
            listBox1.Items.Add(inte);
            listBox1.Items.Add(circ);
            listBox1.Items.Add(musc);
            listBox1.Items.Add(brea);
            listBox1.Items.Add(prol);
            listBox1.Items.Add(nutr);
            listBox1.Items.Add(habi);
            listBox1.Items.Add(swim);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Monkey mon = new Monkey("omnivore", "America,Africa,Asia", "Lungs", "Breed", "Cartilage and Bone", "Closed circulation", "Striped and smooth muscles");

            string clas = mon.Class();
            string inte = mon.InternalSkeletonStructureInfo();
            string circ = mon.CirculatorySystemTypeInfo();
            string musc = mon.MuscleTypeInfo();
            string brea = mon.BreathingPatternInfo();
            string prol = mon.FormOfProliferationInfo();
            string nutr = mon.Nutrition();
            string habi = mon.HabitatInfo();

            listBox1.Items.Add("MONKEY");
            listBox1.Items.Add("Class: " + clas);
            listBox1.Items.Add("Internal Skeleton Structure: " + mon.InternalSkeletonStructure);
            listBox1.Items.Add("Circulatory System Type: " + mon.CirculatorySystemType);
            listBox1.Items.Add("Muscle Type: " + mon.MuscleType);
            listBox1.Items.Add("Breathing Pattern: " + mon.BreathingPattern);
            listBox1.Items.Add("Form of Proliferation: " + mon.FormOfProliferation);
            listBox1.Items.Add("Nutrition Types: " + mon.NutritionTypes);
            listBox1.Items.Add("Habitat: " + mon.Habitat);
            listBox1.Items.Add(inte);
            listBox1.Items.Add(circ);
            listBox1.Items.Add(musc);
            listBox1.Items.Add(brea);
            listBox1.Items.Add(prol);
            listBox1.Items.Add(nutr);
            listBox1.Items.Add(habi);
 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Penguin pen = new Penguin("Lungs", "Eggs", 20 , 7 , "South Pole", "Swim and Walk", "Cartilage and Bone", "Closed circulation", "Striped and smooth muscles");

            string inte = pen.InternalSkeletonStructureInfo();
            string circ = pen.CirculatorySystemTypeInfo();
            string musc = pen.MuscleTypeInfo();
            string brea = pen.BreathingPatternInfo();
            string prol = pen.FormOfProliferationInfo();
            string swim = pen.Swim();

            listBox1.Items.Add("PENGUIN");
            listBox1.Items.Add("Internal Skeleton Structure: " + pen.InternalSkeletonStructure);
            listBox1.Items.Add("Circulatory System Type: " + pen.CirculatorySystemType);
            listBox1.Items.Add("Muscle Type: " + pen.MuscleType);
            listBox1.Items.Add("Breathing Pattern: " + pen.BreathingPattern);
            listBox1.Items.Add("Form of Proliferation: " + pen.FormOfProliferation);
            listBox1.Items.Add("Habitat: " + pen.Habitat);
            listBox1.Items.Add("Wing Width: " + pen.WingWidth);
            listBox1.Items.Add("Beak Length: " + pen.BeakLength);
            listBox1.Items.Add("Mode of Action: " + pen.ModeOfAction);
            listBox1.Items.Add(inte);
            listBox1.Items.Add(circ);
            listBox1.Items.Add(musc);
            listBox1.Items.Add(brea);
            listBox1.Items.Add(prol);
            listBox1.Items.Add(swim);

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            KingFisher pen = new KingFisher("Lungs", "Eggs", 12, 8, "Japan", "Fly", "Cartilage and Bone", "Closed circulation", "Striped and smooth muscles");

            string inte = pen.InternalSkeletonStructureInfo();
            string circ = pen.CirculatorySystemTypeInfo();
            string musc = pen.MuscleTypeInfo();
            string brea = pen.BreathingPatternInfo();
            string prol = pen.FormOfProliferationInfo();
            string fly = pen.Fly();

            listBox1.Items.Add("KINGFISHER");
            listBox1.Items.Add("Internal Skeleton Structure: " + pen.InternalSkeletonStructure);
            listBox1.Items.Add("Circulatory System Type: " + pen.CirculatorySystemType);
            listBox1.Items.Add("Muscle Type: " + pen.MuscleType);
            listBox1.Items.Add("Breathing Pattern: " + pen.BreathingPattern);
            listBox1.Items.Add("Form of Proliferation: " + pen.FormOfProliferation);
            listBox1.Items.Add("Habitat: " + pen.Habitat);
            listBox1.Items.Add("Wing Width: " + pen.WingWidth);
            listBox1.Items.Add("Beak Length: " + pen.BeakLength);
            listBox1.Items.Add("Mode of Action: " + pen.ModeOfAction);
            listBox1.Items.Add(inte);
            listBox1.Items.Add(circ);
            listBox1.Items.Add(musc);
            listBox1.Items.Add(brea);
            listBox1.Items.Add(prol);
            listBox1.Items.Add(fly);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            VictoriaCrownedPigeon vic = new VictoriaCrownedPigeon("Lungs", "Eggs", 36, 8, "New Guinea", "Fly", "Cartilage and Bone", "Closed circulation", "Striped and smooth muscles");

            string inte = vic.InternalSkeletonStructureInfo();
            string circ = vic.CirculatorySystemTypeInfo();
            string musc = vic.MuscleTypeInfo();
            string brea = vic.BreathingPatternInfo();
            string prol = vic.FormOfProliferationInfo();
            string fly = vic.Fly();

            listBox1.Items.Add("KINGFISHER");
            listBox1.Items.Add("Internal Skeleton Structure: " + vic.InternalSkeletonStructure);
            listBox1.Items.Add("Circulatory System Type: " + vic.CirculatorySystemType);
            listBox1.Items.Add("Muscle Type: " + vic.MuscleType);
            listBox1.Items.Add("Breathing Pattern: " + vic.BreathingPattern);
            listBox1.Items.Add("Form of Proliferation: " + vic.FormOfProliferation);
            listBox1.Items.Add("Habitat: " + vic.Habitat);
            listBox1.Items.Add("Wing Width: " + vic.WingWidth);
            listBox1.Items.Add("Beak Length: " + vic.BeakLength);
            listBox1.Items.Add("Mode of Action: " + vic.ModeOfAction);
            listBox1.Items.Add(inte);
            listBox1.Items.Add(circ);
            listBox1.Items.Add(musc);
            listBox1.Items.Add(brea);
            listBox1.Items.Add(prol);
            listBox1.Items.Add(fly);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            LargeCheckeredSkipper lar = new LargeCheckeredSkipper("6-12 months", "Head-Chest-Abdomen", "Separate Sexual", "No Skeletal System", "Open");

            string inte = lar.InternalSkeletonStructureInfo();
            string circ = lar.CirculatorySystemTypeInfo();
            string prol = lar.FormOfProliferationInfo();
            string fly = lar.Fly();

            listBox1.Items.Add("LARGE CHECKERED SKIPPER");
            listBox1.Items.Add("Internal Skeleton Structure: " + lar.InternalSkeletonStructure);
            listBox1.Items.Add("Circulatory System Type: " + lar.CirculatorySystemType);
            listBox1.Items.Add("Form of Proliferation: " + lar.FormOfProliferation);
            listBox1.Items.Add("Average Life Span: " + lar.AverageLifeSpan);
            listBox1.Items.Add("Body Parts: " + lar.BodyParts);
            listBox1.Items.Add(inte);
            listBox1.Items.Add(circ);
            listBox1.Items.Add(prol);
            listBox1.Items.Add(fly);
        }
    }
}
