using System;
using System.Collections.Generic;
public class rc_vector<T>
{
	private List<int> rowIdx;
	private List<int> colIdx;
	private int size;
	public List<int> RowIdx
	{
		get { return rowIdx; }
		set	{ rowIdx = value; }
	}
	public List<int> ColIdx
	{
		get { return colIdx; }
		set	{ colIdx = value; }
	}
	public int Size
	{
		get { return size; }
		set	{ size = value;}
	}
	public rc_vector(){
		this.size=0;
		this.rowIdx=new List<int>();
		this.colIdx=new List<int>();
	}
	public rc_vector(int size_,  List<int> rows_, List<int> cols_)
	{
		this.rowIdx = rows_;
		this.colIdx = cols_;
		this.size = size_;
	}
	public rc_vector(rc_vector<T> init)
	{
		this.colIdx = init.colIdx;
		this.rowIdx = init.rowIdx;
		this.size = init.size;
	}
	public rc_vector<T> append(int row_, int col_)
	{
		this.ColIdx.Add(col_);
		this.RowIdx.Add(row_);
		size++;
		return this;
	}
	public rc_vector<T> add(rc_vector<T> b)
	{
		for (int i = 0; i < b.size; i++)
		{
			this.append(b.rowIdx[i], b.colIdx[i]);
		}
		return this;
	}
	public static rc_vector<T> operator +(rc_vector<T> a, rc_vector<T> b)
	{
		for (int i = 0; i < b.size; i++)
		{
			a.append(b.rowIdx[i], b.colIdx[i]);
		}
		return a;

	}
	public rc_vector<T> difference(rc_vector<T> subtrahend){
		List<int> colCandidates=new List<int>();
		for(int i =0;i<subtrahend.size;i++){
			colCandidates= new List<int>();
			colCandidates=this.colIdx.FindAll(s=>FindMatchingIndexPred<int>(s,i));
			List<int> rowCandidates = new List<int>();
			for(int j=0;j<subtrahend.Size;j++){
				rowCandidates= colCandidates.FindAll(s =>FindMatchingIndexPred<int>(s,j));
				//find the indices of these.
			}	
		}
		foreach (int i in colCandidates)
            {
                Console.WriteLine(i);
            }
		return new rc_vector<T>();
	}
	private static bool FindMatchingIndexPred<M>(M item,M index){
			return (item.Equals(index));
	}

	public int getRow(int idx)
	{
		return this.rowIdx[idx];
	}
	public int getCol(int idx)
	{
		return this.colIdx[idx];
	}
	public int getSize(){
		return this.size;
	}
}