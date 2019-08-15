class Sudoku {

private int[,] sudoku;
private int hor;
private int vert;
private int horRecDim;//Horizontal small rectangle dimension
private int vertRecDim;//Vertical small rectangle dimension

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
}
public Sudoku (rcv_vector<int> given,int hor_,int vert_){
	this.vert=vert_;
	this.hor=hor_;
	sudoku= new int[hor,vert];
	for (int i =0;i<given.getSize();i++){
		sudoku[given.getRow(i),given.getCol(i)]= given.getItem(i);
	}
}
//returns ture if the Value in sudoku[row,col] is in the corresponding square otherwise false
bool checkSquare(int row, int col, int value){
	
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
bool checkRow(int row,int value){
	for(int i = 0;i<hor;i++){
		if(sudoku[row,i]==value){
			return true;
		}
	}
	return false;
}
bool checkCol(int col,int value){
	for(int i = 0;i<vert;i++){
		if(sudoku[i,col]==value){
			return true;
		}
	}
	return false;
}

}