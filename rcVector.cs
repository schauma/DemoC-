using System;
using System.Collections.Generic;
public struct rc_vector<T>
{
	public List<int> rowIdx
	{
		get
		{
			return this.rowIdx;
		}
		set
		{
			this.rowIdx = value;
		}
	}
	public List<int> colIdx
	{
		get
		{
			return this.colIdx;
		}
		set
		{
			this.colIdx = value;
		}
	}
	public int size
	{
		get
		{
			return this.size;
		}
		set
		{
			this.size = value;
		}
	}
	public rc_vector(int size_,  List<int> rows, List<int> cols)
	{
		this.rowIdx = rows;
		this.colIdx = cols;
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
		this.colIdx.Add(col_);
		this.rowIdx.Add(row_);
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
		return new rc_vector<T>();
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