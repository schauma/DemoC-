using System.Collections.Generic;
class Sudoku {

private int[,] sudoku;
private int hor;
private int vert;
private int horRecDim;//Horizontal small rectangle dimension
private int vertRecDim;//Vertical small rectangle dimension

private rc_vector<int> emptyFields;

public Sudoku(int hor_,int vert_,int horRecDim_,int vertRecDim_ ){
vert= vert_;
hor =hor_;
sudoku = new int[hor,vert];
horRecDim=horRecDim_;
vertRecDim=vertRecDim_;
}
public Sudoku(Sudoku init){
	this.sudoku = init.sudoku;
	this.hor=init.hor;
	this.vert=init.vert;
	this.emptyFields=init.emptyFields;
}
public Sudoku (rcv_vector<int> given_,int hor_,int vert_){
	this.vert=vert_;
	this.hor=hor_;
	sudoku= new int[hor,vert];
	for (int i =0;i<given_.getSize();i++){
		sudoku[given_.getRow(i),given_.getCol(i)]= given_.getItem(i);
	}
	this.emptyFields=findEmpyFields(given_);
}
rc_vector<int> findEmpyFields(rcv_vector<int> given_){
	rc_vector<int> empty = new rc_vector<int>();
	rc_vector<int> full = new rc_vector<int>();
	//implement difference
	empty = full.difference(given_.convertToRCVector());

	return empty;
}

rcv_vector<List<int>> getCandidates(){
	rcv_vector<List<int>> candidates = new rcv_vector<List<int>>();
	for(int i = 0;i<emptyFields.getSize();i++){
		//Get the emptyfields by difference of the whole an 
	}
	return candidates;
}

List<int> getCandidates(int row,  int col){
	List<int> candidates = new List<int>();
	for(int i =1;i<10;i++){
		if(!isInSquare(row,col,i) && !isInRow(row,i)&&!isInCol(col,i)){
			candidates.Add(i);
		}
	}
	return candidates;
}


//returns ture if the Value in sudoku[row,col] is in the corresponding square otherwise false
bool isInSquare(int row, int col, int value){
	
	int horSquare=row/horRecDim;
	int vertSquare=col/vertRecDim;
	for(int i = 0;i<horRecDim;i++){
		for(int j= 0;j<vertRecDim;j++){
			if(sudoku[vertRecDim*vertSquare+j,horSquare*horRecDim+i]==value){
				return true;
			}
		}
	}
	return false;
}
bool isInRow(int row,int value){
	for(int i = 0;i<hor;i++){
		if(sudoku[row,i]==value){
			return true;
		}
	}
	return false;
}
bool isInCol(int col,int value){
	for(int i = 0;i<vert;i++){
		if(sudoku[i,col]==value){
			return true;
		}
	}
	return false;
}

}