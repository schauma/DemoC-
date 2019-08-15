using System;
using System.Collections.Generic;
public struct rcv_vector<T>
{

	private List<T> values
	{

		get
		{
			return this.values;
		}
		set
		{
			this.values = value;
		}

	}
	private List<int> rowIdx
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
	private List<int> colIdx
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
	private int size
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
	public rcv_vector(int size_, List<T> data, List<int> rows, List<int> cols)
	{
		this.values = data;
		this.rowIdx = rows;
		this.colIdx = cols;
		this.size = size_;
	}
	public rcv_vector(rcv_vector<T> init)
	{
		this.values = init.values;
		this.colIdx = init.colIdx;
		this.rowIdx = init.rowIdx;
		this.size = init.size;
	}
	public rcv_vector<T> append(int row_, int col_, T item)
	{
		this.colIdx.Add(col_);
		this.rowIdx.Add(row_);
		this.values.Add(item);
		size++;
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
			a.append(b.rowIdx[i], b.colIdx[i], b.values[i]);
		}
		return a;

	}

	public T getItem(int idx)
	{
		return this.values[idx];
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