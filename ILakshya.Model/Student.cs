using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ILakshya.Model
{
    public class Student
    {

        /*       when i found these type errors then 
         *      SqlException: Cannot insert the value NULL into column 'ProfilePicture', table 'IdAdmin.dbo.Students'; column does not allow nulls.UPDATE fails

                ALTER TABLE Students ALTER COLUMN ProfilePicture NVARCHAR(MAX) NULL; 
        */

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]       
        public int Id { get; set; } // Auto-incrementing ID
        public int? EnrollNo { get; set; } // Enroll number (nullable)
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string RollNo { get; set; }
        
        public string? ProfilePicture { get; set; } // Profile picture file path

        /*        [Key]   
                public int Id { get; set; } // Auto-incrementing ID
                public int? EnrollNo { get; set; } // Enroll number (nullable)
                public string Name { get; set; }
                public string FatherName { get; set; }
                public string RollNo { get; set; }
                public int GenKnowledge { get; set; }
                public int Science { get; set; }
                public int EnglishI { get; set; }
                public int EnglishII { get; set; }
                public int HindiI { get; set; }
                public int HindiII { get; set; }
                public int Computer { get; set; }
                public int Sanskrit { get; set; }
                public int Mathematics { get; set; }
                public int SocialStudies { get; set; }
                public int MaxMarks { get; set; } = 5; // Assuming max marks are 5 for all subjects
                public int PassMarks { get; set; } = 2; // Assuming pass marks are 2 for all subjects
                public string? ProfilePicture { get; set; } // Profile picture file path
                [NotMapped]

                public int TotalMarks => GenKnowledge + Science + EnglishI + EnglishII + HindiI + HindiII + Computer + Sanskrit + Mathematics + SocialStudies;

                public int SubGenKnowledge { get; set; }
                public int SubScience { get; set; }
                public int SubEnglishI { get; set; }
                public int SubEnglishII { get; set; }
                public int SubHindiI { get; set; }
                public int SubHindiII { get; set; }
                public int SubComputer { get; set; }
                public int SubSanskrit { get; set; }
                public int SubMathematics { get; set; }
                public int SubSocialStudies { get; set; }

                public int TotalSUbMarks => SubGenKnowledge + SubScience + SubEnglishI + SubEnglishII + SubHindiI + SubHindiII + SubComputer + SubSanskrit + SubMathematics + SubSocialStudies;

                public int YearlyGenKnowledge { get; set; }
                public int YearlyScience { get; set; }
                public int YearlyEnglishI { get; set; }
                public int YearlyEnglishII { get; set; }
                public int YearlyHindiI { get; set; }
                public int YearlyHindiII { get; set; }
                public int YearlyComputer { get; set; }
                public int YearlySanskrit { get; set; }
                public int YearlyMathematics { get; set; }
                public int YearlySocialStudies { get; set; }

                public int YearlyTotalMarks => YearlyGenKnowledge + YearlyScience + YearlyEnglishI + YearlyEnglishII + YearlyHindiI + YearlyHindiII + YearlyComputer + YearlySanskrit + YearlyMathematics + YearlySocialStudies;

        */
    }
}


