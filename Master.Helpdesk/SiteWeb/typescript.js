var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
//JS Standard reconnu
console.log("Test type script");
//classe utilisteur
var Personne = /** @class */ (function () {
    function Personne() {
    }
    return Personne;
}());
var Utilisateur = /** @class */ (function (_super) {
    __extends(Utilisateur, _super);
    function Utilisateur() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Utilisateur.prototype.getAdresse = function () {
        return "";
    };
    Utilisateur.prototype.Profil = function () {
    };
    return Utilisateur;
}(Personne));
var vero = new Utilisateur();
console.log(vero.getAdresse);
//JQUERY 
//$("body").click(function(){;
//$(".class").attr();
//$("#id").show();
//# sourceMappingURL=typescript.js.map