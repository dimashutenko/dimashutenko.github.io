const two=2;
function Fighter(name, damage, hp, strength, agility){
	this.Name=name;
	this.Damage=damage;
	this.Hp=hp;
	this.MaxHp=hp;
	this.Strength=strength;
	this.Agility=agility;
	this.Wins = 0;
	this.Loses = 0;
	this.getName = function () {
		return this.Name;
	}
	this.getDamage = function (){
		return this.Damage;
	}
	this.getStrength = function (){
	return this.Strength;
	}
	this.getAgility = function (){
		return this.Agility;
	}
	this.getHealth = function (){
		return this.Hp;
	}
	this.attack = function (fighter){
		let sucess = Math.floor(Math.random() * Math.floor(two));
		if(sucess===1){
			fighter.Hp = fighter.getHealth()-this.Damage;
			console.log(this.Name+' deals '+ this.Damage+' damage to '+fighter.Name);
			if (fighter.getHealth()<0){
				fighter.Hp=0;
			}
		}else{
			console.log('The attack of '+this.Name+' was not successful');
		}
	}
	this.logCombatHistory = function (){
		console.log('Name: '+this.Name+', Wins: '+this.Wins+', Loses: '+ this.Loses);
	}
	this.heal = function(healing){
		this.Hp+=healing;
		if (this.getHealth()>this.MaxHp){
			this.Hp=this.MaxHp;
		}
	}
	this.dealDamage=function(damage){
		this.Hp-=damage;
		if (this.getHealth()<0){
			this.Hp=0;
		}
	}
	this.addWin=function(){
		this.Wins+=1;
	}
	this.addLoss=function(){
		this.Loses+=1;
	}
}
function battle(fighter_1, fighter_2){
	if (fighter_1.getHealth()===0){
		console.log(fighter1.getName()+' is dead and can not fight');
		console.log(fighter2.getName()+' has won');
		fighter2.addWin();
		fighter1.addLoss();
		return 0;
	}else if (fighter_2.getHealth()===0){
		console.log(fighter2.getName()+' is dead and can not fight');
		console.log(fighter1.getName()+' has won');
		fighter1.addWin();
		fighter2.addLoss();
		return 0;
	}else{
		fighter_1.attack(fighter_2);
		if(fighter_2.getHealth()>0){
			fighter_2.attack(fighter_1);
		}else{
			console.log(fighter_2.Name+' is dead and can not fight');
			console.log(fighter1.getName()+' has won');
			fighter1.addWin();
			fighter2.addLoss();
		}
	}
}
let twentyfive=25;
let thirty=30;
let fourty=40;
let one_hundred=100;
const fighter1 = new Fighter('Tom',twentyfive,one_hundred,thirty,twentyfive);
const fighter2 = new Fighter('Jerry',fourty,one_hundred,thirty,twentyfive);
while(fighter2.getHealth() > 0 ) {
	if (battle(fighter1, fighter2)===0){
		break;
	}
}