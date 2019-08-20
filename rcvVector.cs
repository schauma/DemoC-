using System;
using System.Collections.Generic;
public struct rcv_vector<T>
{
	private List<T> values;
	private List<int> rowIdx;
	private List<int> colIdx;
	private int size;
	public List<T> Values
	{
		get	{ return values;}
		set	{ values = value;}
	}
	public List<int> RowIdx
	{
		get { return rowIdx;}
		set	{ rowIdx = value;}
	}
	public List<int> ColIdx
	{
		get { return this.colIdx;}
		set	{ colIdx = value;}
	}
	public int Size
	{
		get	{ return this.size;}
		set	{ this.size = value;}
	}

	public rcv_vector(int size_, List<T> data, List<int> rows, List<int> cols)
	{
		this.values = data;
		this.rowIdx = rows;
		this.colIdx = cols;
		this.size = size_;
	}
	public rcv_vector(rcv_vector<T> init)
	{
		this.values = init.Values;
		this.colIdx = init.ColIdx;
		this.rowIdx = init.RowIdx;
		this.size = init.Size;
	}
	public rcv_vector<T> append(int row_, int col_, T item)
	{
		this.ColIdx.Add(col_);
		this.RowIdx.Add(row_);
		this.Values.Add(item);
		Size++;
		return this;
	}
	public rcv_vector<T> add(rcv_vector<T> b)
	{
		for (int i = 0; i < b.size; i++)
		{
			this.append(b.rowIdx[i], b.colIdx[i], b.values[i]);
		}
		return this;
	}
	public static rcv_vector<T> operator +(rcv_vector<T> a, rcv_vector<T> b)
	{
		for (int i = 0; i < b.size; i++)
		{
			a.append(b.RowIdx[i], b.ColIdx[i], b.Values[i]);
		}
		return a;

	}
	public rc_vector<T> convertToRCVector(){
		rc_vector<T> rc = new rc_vector<T>(this.Size,this.RowIdx,this.ColIdx);
		rc.Size=this.getSize();
		rc.RowIdx = this.RowIdx;
		rc.ColIdx = this.ColIdx;
		return rc;
	}

	public T getItem(int idx)
	{
		return this.Values[idx];
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
		return this.Size;
	}
}