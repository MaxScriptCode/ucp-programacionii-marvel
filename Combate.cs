using System;
public class Combate{

    #region Atributos

    private Superheroe Superheroe;
    private Villano Villano;
    private int CantidadDeUsosSuperpoder;


    #endregion
    
    #region Constructor
    public Combate(){
        this.Superheroe=new Superheroe();
        this.Villano=new Villano();
        this.CantidadDeUsosSuperpoder=0;
    }

    public Combate(Superheroe super, Villano vil, int usos){
        this.Superheroe=super;
        this.Villano=vil;
        this.CantidadDeUsosSuperpoder=usos;
    }
    #endregion

    #region setters y getters
    //set
    public void SetSuperheroe(Superheroe super){
        this.Superheroe=super;
    }

    public void SetVillano(Villano vil){
        this.Villano=vil;
    }

    public void SetCantidadDeUsosSuperpoder(int cant){
        this.CantidadDeUsosSuperpoder=cant;
    }
    //get
    public Superheroe GetSuperheroe(){
        return this.Superheroe;
    }

    public Villano GetVillano(){
        return this.Villano;
    }
    public int GetCantidadDeUsosSuperpoder(){
        return this.CantidadDeUsosSuperpoder;
    }

    
    #endregion

    #region metodos

    public void Comenzar(){
        
    }
    public void Terminar(){
        
    }
    public void Turno(Personaje p){
        
    }

    #endregion
}