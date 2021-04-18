



//JS Standard reconnu
console.log("Test type script");

//classe utilisteur
class Personne {

}

class Utilisateur extends Personne {

    public Nom: string;
    public Prenom: string;
    public Ancienneté: number;
    public Adresse: any;

    public getAdresse(): string {

        return "";

    }

    public Profil(): void {

    }
}

let vero = new Utilisateur();
console.log(vero.getAdresse);

//JQUERY 
//$("body").click(function(){;
//$(".class").attr();
//$("#id").show();