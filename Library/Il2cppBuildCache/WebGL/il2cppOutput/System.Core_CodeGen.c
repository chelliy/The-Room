#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Exception System.Linq.Error::ArgumentNull(System.String)
extern void Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E (void);
// 0x00000002 System.Exception System.Linq.Error::ArgumentOutOfRange(System.String)
extern void Error_ArgumentOutOfRange_m2EFB999454161A6B48F8DAC3753FDC190538F0F2 (void);
// 0x00000003 System.Exception System.Linq.Error::MoreThanOneMatch()
extern void Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8 (void);
// 0x00000004 System.Exception System.Linq.Error::NoElements()
extern void Error_NoElements_mB89E91246572F009281D79730950808F17C3F353 (void);
// 0x00000005 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Where(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000006 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Select(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TResult>)
// 0x00000007 System.Func`2<TSource,System.Boolean> System.Linq.Enumerable::CombinePredicates(System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,System.Boolean>)
// 0x00000008 System.Func`2<TSource,TResult> System.Linq.Enumerable::CombineSelectors(System.Func`2<TSource,TMiddle>,System.Func`2<TMiddle,TResult>)
// 0x00000009 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectMany(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)
// 0x0000000A System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectManyIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)
// 0x0000000B System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::OrderBy(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x0000000C System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::ThenBy(System.Linq.IOrderedEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x0000000D System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Distinct(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000E System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::DistinctIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x0000000F TSource[] System.Linq.Enumerable::ToArray(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000010 System.Collections.Generic.List`1<TSource> System.Linq.Enumerable::ToList(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000011 TSource System.Linq.Enumerable::First(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000012 TSource System.Linq.Enumerable::FirstOrDefault(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000013 TSource System.Linq.Enumerable::FirstOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000014 TSource System.Linq.Enumerable::Last(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000015 TSource System.Linq.Enumerable::SingleOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000016 TSource System.Linq.Enumerable::ElementAt(System.Collections.Generic.IEnumerable`1<TSource>,System.Int32)
// 0x00000017 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Empty()
// 0x00000018 System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000019 System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000001A System.Boolean System.Linq.Enumerable::All(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000001B System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000001C System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000001D System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource)
// 0x0000001E System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x0000001F System.Void System.Linq.Enumerable/Iterator`1::.ctor()
// 0x00000020 TSource System.Linq.Enumerable/Iterator`1::get_Current()
// 0x00000021 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/Iterator`1::Clone()
// 0x00000022 System.Void System.Linq.Enumerable/Iterator`1::Dispose()
// 0x00000023 System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/Iterator`1::GetEnumerator()
// 0x00000024 System.Boolean System.Linq.Enumerable/Iterator`1::MoveNext()
// 0x00000025 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/Iterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000026 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/Iterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000027 System.Object System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.get_Current()
// 0x00000028 System.Collections.IEnumerator System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000029 System.Void System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.Reset()
// 0x0000002A System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000002B System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Clone()
// 0x0000002C System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::Dispose()
// 0x0000002D System.Boolean System.Linq.Enumerable/WhereEnumerableIterator`1::MoveNext()
// 0x0000002E System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereEnumerableIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x0000002F System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000030 System.Void System.Linq.Enumerable/WhereArrayIterator`1::.ctor(TSource[],System.Func`2<TSource,System.Boolean>)
// 0x00000031 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Clone()
// 0x00000032 System.Boolean System.Linq.Enumerable/WhereArrayIterator`1::MoveNext()
// 0x00000033 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereArrayIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000034 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000035 System.Void System.Linq.Enumerable/WhereListIterator`1::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000036 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Clone()
// 0x00000037 System.Boolean System.Linq.Enumerable/WhereListIterator`1::MoveNext()
// 0x00000038 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereListIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000039 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x0000003A System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x0000003B System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Clone()
// 0x0000003C System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Dispose()
// 0x0000003D System.Boolean System.Linq.Enumerable/WhereSelectEnumerableIterator`2::MoveNext()
// 0x0000003E System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x0000003F System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000040 System.Void System.Linq.Enumerable/WhereSelectArrayIterator`2::.ctor(TSource[],System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000041 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Clone()
// 0x00000042 System.Boolean System.Linq.Enumerable/WhereSelectArrayIterator`2::MoveNext()
// 0x00000043 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectArrayIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000044 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000045 System.Void System.Linq.Enumerable/WhereSelectListIterator`2::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000046 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Clone()
// 0x00000047 System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2::MoveNext()
// 0x00000048 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectListIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000049 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x0000004A System.Void System.Linq.Enumerable/<>c__DisplayClass6_0`1::.ctor()
// 0x0000004B System.Boolean System.Linq.Enumerable/<>c__DisplayClass6_0`1::<CombinePredicates>b__0(TSource)
// 0x0000004C System.Void System.Linq.Enumerable/<>c__DisplayClass7_0`3::.ctor()
// 0x0000004D TResult System.Linq.Enumerable/<>c__DisplayClass7_0`3::<CombineSelectors>b__0(TSource)
// 0x0000004E System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::.ctor(System.Int32)
// 0x0000004F System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.IDisposable.Dispose()
// 0x00000050 System.Boolean System.Linq.Enumerable/<SelectManyIterator>d__17`2::MoveNext()
// 0x00000051 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::<>m__Finally1()
// 0x00000052 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::<>m__Finally2()
// 0x00000053 TResult System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerator<TResult>.get_Current()
// 0x00000054 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerator.Reset()
// 0x00000055 System.Object System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerator.get_Current()
// 0x00000056 System.Collections.Generic.IEnumerator`1<TResult> System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
// 0x00000057 System.Collections.IEnumerator System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerable.GetEnumerator()
// 0x00000058 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::.ctor(System.Int32)
// 0x00000059 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::System.IDisposable.Dispose()
// 0x0000005A System.Boolean System.Linq.Enumerable/<DistinctIterator>d__68`1::MoveNext()
// 0x0000005B System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::<>m__Finally1()
// 0x0000005C TSource System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerator<TSource>.get_Current()
// 0x0000005D System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.Reset()
// 0x0000005E System.Object System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.get_Current()
// 0x0000005F System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
// 0x00000060 System.Collections.IEnumerator System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000061 System.Void System.Linq.EmptyEnumerable`1::.cctor()
// 0x00000062 System.Linq.IOrderedEnumerable`1<TElement> System.Linq.IOrderedEnumerable`1::CreateOrderedEnumerable(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x00000063 System.Void System.Linq.Set`1::.ctor(System.Collections.Generic.IEqualityComparer`1<TElement>)
// 0x00000064 System.Boolean System.Linq.Set`1::Add(TElement)
// 0x00000065 System.Boolean System.Linq.Set`1::Find(TElement,System.Boolean)
// 0x00000066 System.Void System.Linq.Set`1::Resize()
// 0x00000067 System.Int32 System.Linq.Set`1::InternalGetHashCode(TElement)
// 0x00000068 System.Collections.Generic.IEnumerator`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerator()
// 0x00000069 System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x0000006A System.Collections.IEnumerator System.Linq.OrderedEnumerable`1::System.Collections.IEnumerable.GetEnumerator()
// 0x0000006B System.Linq.IOrderedEnumerable`1<TElement> System.Linq.OrderedEnumerable`1::System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x0000006C System.Void System.Linq.OrderedEnumerable`1::.ctor()
// 0x0000006D System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::.ctor(System.Int32)
// 0x0000006E System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.IDisposable.Dispose()
// 0x0000006F System.Boolean System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::MoveNext()
// 0x00000070 TElement System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.Generic.IEnumerator<TElement>.get_Current()
// 0x00000071 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.Reset()
// 0x00000072 System.Object System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.get_Current()
// 0x00000073 System.Void System.Linq.OrderedEnumerable`2::.ctor(System.Collections.Generic.IEnumerable`1<TElement>,System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x00000074 System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`2::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x00000075 System.Void System.Linq.EnumerableSorter`1::ComputeKeys(TElement[],System.Int32)
// 0x00000076 System.Int32 System.Linq.EnumerableSorter`1::CompareKeys(System.Int32,System.Int32)
// 0x00000077 System.Int32[] System.Linq.EnumerableSorter`1::Sort(TElement[],System.Int32)
// 0x00000078 System.Void System.Linq.EnumerableSorter`1::QuickSort(System.Int32[],System.Int32,System.Int32)
// 0x00000079 System.Void System.Linq.EnumerableSorter`1::.ctor()
// 0x0000007A System.Void System.Linq.EnumerableSorter`2::.ctor(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean,System.Linq.EnumerableSorter`1<TElement>)
// 0x0000007B System.Void System.Linq.EnumerableSorter`2::ComputeKeys(TElement[],System.Int32)
// 0x0000007C System.Int32 System.Linq.EnumerableSorter`2::CompareKeys(System.Int32,System.Int32)
// 0x0000007D System.Void System.Linq.Buffer`1::.ctor(System.Collections.Generic.IEnumerable`1<TElement>)
// 0x0000007E TElement[] System.Linq.Buffer`1::ToArray()
// 0x0000007F System.Void System.Collections.Generic.HashSet`1::.ctor()
// 0x00000080 System.Void System.Collections.Generic.HashSet`1::.ctor(System.Collections.Generic.IEqualityComparer`1<T>)
// 0x00000081 System.Void System.Collections.Generic.HashSet`1::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x00000082 System.Void System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.Add(T)
// 0x00000083 System.Void System.Collections.Generic.HashSet`1::Clear()
// 0x00000084 System.Boolean System.Collections.Generic.HashSet`1::Contains(T)
// 0x00000085 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32)
// 0x00000086 System.Boolean System.Collections.Generic.HashSet`1::Remove(T)
// 0x00000087 System.Int32 System.Collections.Generic.HashSet`1::get_Count()
// 0x00000088 System.Boolean System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.get_IsReadOnly()
// 0x00000089 System.Collections.Generic.HashSet`1/Enumerator<T> System.Collections.Generic.HashSet`1::GetEnumerator()
// 0x0000008A System.Collections.Generic.IEnumerator`1<T> System.Collections.Generic.HashSet`1::System.Collections.Generic.IEnumerable<T>.GetEnumerator()
// 0x0000008B System.Collections.IEnumerator System.Collections.Generic.HashSet`1::System.Collections.IEnumerable.GetEnumerator()
// 0x0000008C System.Void System.Collections.Generic.HashSet`1::GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x0000008D System.Void System.Collections.Generic.HashSet`1::OnDeserialization(System.Object)
// 0x0000008E System.Boolean System.Collections.Generic.HashSet`1::Add(T)
// 0x0000008F System.Void System.Collections.Generic.HashSet`1::CopyTo(T[])
// 0x00000090 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32,System.Int32)
// 0x00000091 System.Void System.Collections.Generic.HashSet`1::Initialize(System.Int32)
// 0x00000092 System.Void System.Collections.Generic.HashSet`1::IncreaseCapacity()
// 0x00000093 System.Void System.Collections.Generic.HashSet`1::SetCapacity(System.Int32)
// 0x00000094 System.Boolean System.Collections.Generic.HashSet`1::AddIfNotPresent(T)
// 0x00000095 System.Int32 System.Collections.Generic.HashSet`1::InternalGetHashCode(T)
// 0x00000096 System.Void System.Collections.Generic.HashSet`1/Enumerator::.ctor(System.Collections.Generic.HashSet`1<T>)
// 0x00000097 System.Void System.Collections.Generic.HashSet`1/Enumerator::Dispose()
// 0x00000098 System.Boolean System.Collections.Generic.HashSet`1/Enumerator::MoveNext()
// 0x00000099 T System.Collections.Generic.HashSet`1/Enumerator::get_Current()
// 0x0000009A System.Object System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.get_Current()
// 0x0000009B System.Void System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.Reset()
static Il2CppMethodPointer s_methodPointers[155] = 
{
	Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E,
	Error_ArgumentOutOfRange_m2EFB999454161A6B48F8DAC3753FDC190538F0F2,
	Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8,
	Error_NoElements_mB89E91246572F009281D79730950808F17C3F353,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
};
static const int32_t s_InvokerIndices[155] = 
{
	5023,
	5023,
	5266,
	5266,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
};
static const Il2CppTokenRangePair s_rgctxIndices[54] = 
{
	{ 0x02000004, { 85, 4 } },
	{ 0x02000005, { 89, 9 } },
	{ 0x02000006, { 100, 7 } },
	{ 0x02000007, { 109, 10 } },
	{ 0x02000008, { 121, 11 } },
	{ 0x02000009, { 135, 9 } },
	{ 0x0200000A, { 147, 12 } },
	{ 0x0200000B, { 162, 1 } },
	{ 0x0200000C, { 163, 2 } },
	{ 0x0200000D, { 165, 12 } },
	{ 0x0200000E, { 177, 11 } },
	{ 0x0200000F, { 188, 2 } },
	{ 0x02000011, { 190, 8 } },
	{ 0x02000013, { 198, 3 } },
	{ 0x02000014, { 203, 5 } },
	{ 0x02000015, { 208, 7 } },
	{ 0x02000016, { 215, 3 } },
	{ 0x02000017, { 218, 7 } },
	{ 0x02000018, { 225, 4 } },
	{ 0x02000019, { 229, 21 } },
	{ 0x0200001B, { 250, 2 } },
	{ 0x06000005, { 0, 10 } },
	{ 0x06000006, { 10, 10 } },
	{ 0x06000007, { 20, 5 } },
	{ 0x06000008, { 25, 5 } },
	{ 0x06000009, { 30, 1 } },
	{ 0x0600000A, { 31, 2 } },
	{ 0x0600000B, { 33, 2 } },
	{ 0x0600000C, { 35, 1 } },
	{ 0x0600000D, { 36, 1 } },
	{ 0x0600000E, { 37, 2 } },
	{ 0x0600000F, { 39, 3 } },
	{ 0x06000010, { 42, 2 } },
	{ 0x06000011, { 44, 4 } },
	{ 0x06000012, { 48, 4 } },
	{ 0x06000013, { 52, 3 } },
	{ 0x06000014, { 55, 4 } },
	{ 0x06000015, { 59, 3 } },
	{ 0x06000016, { 62, 3 } },
	{ 0x06000017, { 65, 1 } },
	{ 0x06000018, { 66, 1 } },
	{ 0x06000019, { 67, 3 } },
	{ 0x0600001A, { 70, 3 } },
	{ 0x0600001B, { 73, 2 } },
	{ 0x0600001C, { 75, 3 } },
	{ 0x0600001D, { 78, 2 } },
	{ 0x0600001E, { 80, 5 } },
	{ 0x0600002E, { 98, 2 } },
	{ 0x06000033, { 107, 2 } },
	{ 0x06000038, { 119, 2 } },
	{ 0x0600003E, { 132, 3 } },
	{ 0x06000043, { 144, 3 } },
	{ 0x06000048, { 159, 3 } },
	{ 0x0600006B, { 201, 2 } },
};
static const Il2CppRGCTXDefinition s_rgctxValues[252] = 
{
	{ (Il2CppRGCTXDataType)2, 2510 },
	{ (Il2CppRGCTXDataType)3, 9909 },
	{ (Il2CppRGCTXDataType)2, 4081 },
	{ (Il2CppRGCTXDataType)2, 3471 },
	{ (Il2CppRGCTXDataType)3, 18951 },
	{ (Il2CppRGCTXDataType)2, 2634 },
	{ (Il2CppRGCTXDataType)2, 3478 },
	{ (Il2CppRGCTXDataType)3, 19007 },
	{ (Il2CppRGCTXDataType)2, 3473 },
	{ (Il2CppRGCTXDataType)3, 18963 },
	{ (Il2CppRGCTXDataType)2, 2511 },
	{ (Il2CppRGCTXDataType)3, 9910 },
	{ (Il2CppRGCTXDataType)2, 4113 },
	{ (Il2CppRGCTXDataType)2, 3483 },
	{ (Il2CppRGCTXDataType)3, 19022 },
	{ (Il2CppRGCTXDataType)2, 2654 },
	{ (Il2CppRGCTXDataType)2, 3491 },
	{ (Il2CppRGCTXDataType)3, 19224 },
	{ (Il2CppRGCTXDataType)2, 3487 },
	{ (Il2CppRGCTXDataType)3, 19114 },
	{ (Il2CppRGCTXDataType)2, 874 },
	{ (Il2CppRGCTXDataType)3, 73 },
	{ (Il2CppRGCTXDataType)3, 74 },
	{ (Il2CppRGCTXDataType)2, 1539 },
	{ (Il2CppRGCTXDataType)3, 7016 },
	{ (Il2CppRGCTXDataType)2, 876 },
	{ (Il2CppRGCTXDataType)3, 93 },
	{ (Il2CppRGCTXDataType)3, 94 },
	{ (Il2CppRGCTXDataType)2, 1555 },
	{ (Il2CppRGCTXDataType)3, 7023 },
	{ (Il2CppRGCTXDataType)3, 22522 },
	{ (Il2CppRGCTXDataType)2, 883 },
	{ (Il2CppRGCTXDataType)3, 181 },
	{ (Il2CppRGCTXDataType)2, 3100 },
	{ (Il2CppRGCTXDataType)3, 15490 },
	{ (Il2CppRGCTXDataType)3, 7741 },
	{ (Il2CppRGCTXDataType)3, 22473 },
	{ (Il2CppRGCTXDataType)2, 877 },
	{ (Il2CppRGCTXDataType)3, 139 },
	{ (Il2CppRGCTXDataType)2, 1032 },
	{ (Il2CppRGCTXDataType)3, 1338 },
	{ (Il2CppRGCTXDataType)3, 1339 },
	{ (Il2CppRGCTXDataType)2, 2635 },
	{ (Il2CppRGCTXDataType)3, 10663 },
	{ (Il2CppRGCTXDataType)2, 2286 },
	{ (Il2CppRGCTXDataType)2, 1746 },
	{ (Il2CppRGCTXDataType)2, 1867 },
	{ (Il2CppRGCTXDataType)2, 1992 },
	{ (Il2CppRGCTXDataType)2, 2287 },
	{ (Il2CppRGCTXDataType)2, 1747 },
	{ (Il2CppRGCTXDataType)2, 1868 },
	{ (Il2CppRGCTXDataType)2, 1993 },
	{ (Il2CppRGCTXDataType)2, 1869 },
	{ (Il2CppRGCTXDataType)2, 1994 },
	{ (Il2CppRGCTXDataType)3, 7018 },
	{ (Il2CppRGCTXDataType)2, 2288 },
	{ (Il2CppRGCTXDataType)2, 1748 },
	{ (Il2CppRGCTXDataType)2, 1870 },
	{ (Il2CppRGCTXDataType)2, 1995 },
	{ (Il2CppRGCTXDataType)2, 1871 },
	{ (Il2CppRGCTXDataType)2, 1996 },
	{ (Il2CppRGCTXDataType)3, 7019 },
	{ (Il2CppRGCTXDataType)2, 2285 },
	{ (Il2CppRGCTXDataType)2, 1866 },
	{ (Il2CppRGCTXDataType)2, 1991 },
	{ (Il2CppRGCTXDataType)2, 1333 },
	{ (Il2CppRGCTXDataType)2, 1855 },
	{ (Il2CppRGCTXDataType)2, 1856 },
	{ (Il2CppRGCTXDataType)2, 1988 },
	{ (Il2CppRGCTXDataType)3, 7015 },
	{ (Il2CppRGCTXDataType)2, 1854 },
	{ (Il2CppRGCTXDataType)2, 1987 },
	{ (Il2CppRGCTXDataType)3, 7014 },
	{ (Il2CppRGCTXDataType)2, 1745 },
	{ (Il2CppRGCTXDataType)2, 1864 },
	{ (Il2CppRGCTXDataType)2, 1865 },
	{ (Il2CppRGCTXDataType)2, 1990 },
	{ (Il2CppRGCTXDataType)3, 7017 },
	{ (Il2CppRGCTXDataType)2, 1744 },
	{ (Il2CppRGCTXDataType)3, 22446 },
	{ (Il2CppRGCTXDataType)3, 6199 },
	{ (Il2CppRGCTXDataType)2, 1407 },
	{ (Il2CppRGCTXDataType)2, 1858 },
	{ (Il2CppRGCTXDataType)2, 1989 },
	{ (Il2CppRGCTXDataType)2, 2097 },
	{ (Il2CppRGCTXDataType)3, 9911 },
	{ (Il2CppRGCTXDataType)3, 9913 },
	{ (Il2CppRGCTXDataType)2, 624 },
	{ (Il2CppRGCTXDataType)3, 9912 },
	{ (Il2CppRGCTXDataType)3, 9921 },
	{ (Il2CppRGCTXDataType)2, 2514 },
	{ (Il2CppRGCTXDataType)2, 3474 },
	{ (Il2CppRGCTXDataType)3, 18964 },
	{ (Il2CppRGCTXDataType)3, 9922 },
	{ (Il2CppRGCTXDataType)2, 1922 },
	{ (Il2CppRGCTXDataType)2, 2028 },
	{ (Il2CppRGCTXDataType)3, 7031 },
	{ (Il2CppRGCTXDataType)3, 22407 },
	{ (Il2CppRGCTXDataType)2, 3488 },
	{ (Il2CppRGCTXDataType)3, 19115 },
	{ (Il2CppRGCTXDataType)3, 9914 },
	{ (Il2CppRGCTXDataType)2, 2513 },
	{ (Il2CppRGCTXDataType)2, 3472 },
	{ (Il2CppRGCTXDataType)3, 18952 },
	{ (Il2CppRGCTXDataType)3, 7030 },
	{ (Il2CppRGCTXDataType)3, 9915 },
	{ (Il2CppRGCTXDataType)3, 22406 },
	{ (Il2CppRGCTXDataType)2, 3484 },
	{ (Il2CppRGCTXDataType)3, 19023 },
	{ (Il2CppRGCTXDataType)3, 9928 },
	{ (Il2CppRGCTXDataType)2, 2515 },
	{ (Il2CppRGCTXDataType)2, 3479 },
	{ (Il2CppRGCTXDataType)3, 19008 },
	{ (Il2CppRGCTXDataType)3, 10716 },
	{ (Il2CppRGCTXDataType)3, 4873 },
	{ (Il2CppRGCTXDataType)3, 7032 },
	{ (Il2CppRGCTXDataType)3, 4872 },
	{ (Il2CppRGCTXDataType)3, 9929 },
	{ (Il2CppRGCTXDataType)3, 22408 },
	{ (Il2CppRGCTXDataType)2, 3492 },
	{ (Il2CppRGCTXDataType)3, 19225 },
	{ (Il2CppRGCTXDataType)3, 9942 },
	{ (Il2CppRGCTXDataType)2, 2517 },
	{ (Il2CppRGCTXDataType)2, 3490 },
	{ (Il2CppRGCTXDataType)3, 19117 },
	{ (Il2CppRGCTXDataType)3, 9943 },
	{ (Il2CppRGCTXDataType)2, 1925 },
	{ (Il2CppRGCTXDataType)2, 2031 },
	{ (Il2CppRGCTXDataType)3, 7036 },
	{ (Il2CppRGCTXDataType)3, 7035 },
	{ (Il2CppRGCTXDataType)2, 3476 },
	{ (Il2CppRGCTXDataType)3, 18966 },
	{ (Il2CppRGCTXDataType)3, 22417 },
	{ (Il2CppRGCTXDataType)2, 3489 },
	{ (Il2CppRGCTXDataType)3, 19116 },
	{ (Il2CppRGCTXDataType)3, 9935 },
	{ (Il2CppRGCTXDataType)2, 2516 },
	{ (Il2CppRGCTXDataType)2, 3486 },
	{ (Il2CppRGCTXDataType)3, 19025 },
	{ (Il2CppRGCTXDataType)3, 7034 },
	{ (Il2CppRGCTXDataType)3, 7033 },
	{ (Il2CppRGCTXDataType)3, 9936 },
	{ (Il2CppRGCTXDataType)2, 3475 },
	{ (Il2CppRGCTXDataType)3, 18965 },
	{ (Il2CppRGCTXDataType)3, 22416 },
	{ (Il2CppRGCTXDataType)2, 3485 },
	{ (Il2CppRGCTXDataType)3, 19024 },
	{ (Il2CppRGCTXDataType)3, 9949 },
	{ (Il2CppRGCTXDataType)2, 2518 },
	{ (Il2CppRGCTXDataType)2, 3494 },
	{ (Il2CppRGCTXDataType)3, 19227 },
	{ (Il2CppRGCTXDataType)3, 10717 },
	{ (Il2CppRGCTXDataType)3, 4875 },
	{ (Il2CppRGCTXDataType)3, 7038 },
	{ (Il2CppRGCTXDataType)3, 7037 },
	{ (Il2CppRGCTXDataType)3, 4874 },
	{ (Il2CppRGCTXDataType)3, 9950 },
	{ (Il2CppRGCTXDataType)2, 3477 },
	{ (Il2CppRGCTXDataType)3, 18967 },
	{ (Il2CppRGCTXDataType)3, 22418 },
	{ (Il2CppRGCTXDataType)2, 3493 },
	{ (Il2CppRGCTXDataType)3, 19226 },
	{ (Il2CppRGCTXDataType)3, 7027 },
	{ (Il2CppRGCTXDataType)3, 7028 },
	{ (Il2CppRGCTXDataType)3, 7042 },
	{ (Il2CppRGCTXDataType)3, 184 },
	{ (Il2CppRGCTXDataType)3, 183 },
	{ (Il2CppRGCTXDataType)2, 1917 },
	{ (Il2CppRGCTXDataType)2, 2024 },
	{ (Il2CppRGCTXDataType)3, 7029 },
	{ (Il2CppRGCTXDataType)2, 1936 },
	{ (Il2CppRGCTXDataType)2, 2048 },
	{ (Il2CppRGCTXDataType)3, 186 },
	{ (Il2CppRGCTXDataType)2, 795 },
	{ (Il2CppRGCTXDataType)2, 884 },
	{ (Il2CppRGCTXDataType)3, 182 },
	{ (Il2CppRGCTXDataType)3, 185 },
	{ (Il2CppRGCTXDataType)3, 141 },
	{ (Il2CppRGCTXDataType)2, 3254 },
	{ (Il2CppRGCTXDataType)3, 17660 },
	{ (Il2CppRGCTXDataType)2, 1914 },
	{ (Il2CppRGCTXDataType)2, 2022 },
	{ (Il2CppRGCTXDataType)3, 17661 },
	{ (Il2CppRGCTXDataType)3, 143 },
	{ (Il2CppRGCTXDataType)2, 621 },
	{ (Il2CppRGCTXDataType)2, 878 },
	{ (Il2CppRGCTXDataType)3, 140 },
	{ (Il2CppRGCTXDataType)3, 142 },
	{ (Il2CppRGCTXDataType)2, 4124 },
	{ (Il2CppRGCTXDataType)2, 1334 },
	{ (Il2CppRGCTXDataType)3, 6236 },
	{ (Il2CppRGCTXDataType)2, 1423 },
	{ (Il2CppRGCTXDataType)2, 4210 },
	{ (Il2CppRGCTXDataType)3, 17657 },
	{ (Il2CppRGCTXDataType)3, 17658 },
	{ (Il2CppRGCTXDataType)2, 2112 },
	{ (Il2CppRGCTXDataType)3, 17659 },
	{ (Il2CppRGCTXDataType)2, 551 },
	{ (Il2CppRGCTXDataType)2, 881 },
	{ (Il2CppRGCTXDataType)3, 167 },
	{ (Il2CppRGCTXDataType)3, 15477 },
	{ (Il2CppRGCTXDataType)2, 3101 },
	{ (Il2CppRGCTXDataType)3, 15491 },
	{ (Il2CppRGCTXDataType)2, 1033 },
	{ (Il2CppRGCTXDataType)3, 1340 },
	{ (Il2CppRGCTXDataType)3, 15483 },
	{ (Il2CppRGCTXDataType)3, 4845 },
	{ (Il2CppRGCTXDataType)2, 663 },
	{ (Il2CppRGCTXDataType)3, 15478 },
	{ (Il2CppRGCTXDataType)2, 3097 },
	{ (Il2CppRGCTXDataType)3, 1461 },
	{ (Il2CppRGCTXDataType)2, 1069 },
	{ (Il2CppRGCTXDataType)2, 1367 },
	{ (Il2CppRGCTXDataType)3, 4851 },
	{ (Il2CppRGCTXDataType)3, 15479 },
	{ (Il2CppRGCTXDataType)3, 4840 },
	{ (Il2CppRGCTXDataType)3, 4841 },
	{ (Il2CppRGCTXDataType)3, 4839 },
	{ (Il2CppRGCTXDataType)3, 4842 },
	{ (Il2CppRGCTXDataType)2, 1363 },
	{ (Il2CppRGCTXDataType)2, 4171 },
	{ (Il2CppRGCTXDataType)3, 7025 },
	{ (Il2CppRGCTXDataType)3, 4844 },
	{ (Il2CppRGCTXDataType)2, 1835 },
	{ (Il2CppRGCTXDataType)3, 4843 },
	{ (Il2CppRGCTXDataType)2, 1750 },
	{ (Il2CppRGCTXDataType)2, 4116 },
	{ (Il2CppRGCTXDataType)2, 1889 },
	{ (Il2CppRGCTXDataType)2, 2001 },
	{ (Il2CppRGCTXDataType)3, 6217 },
	{ (Il2CppRGCTXDataType)2, 1416 },
	{ (Il2CppRGCTXDataType)3, 7565 },
	{ (Il2CppRGCTXDataType)3, 7566 },
	{ (Il2CppRGCTXDataType)3, 7571 },
	{ (Il2CppRGCTXDataType)2, 2106 },
	{ (Il2CppRGCTXDataType)3, 7568 },
	{ (Il2CppRGCTXDataType)3, 23159 },
	{ (Il2CppRGCTXDataType)2, 1369 },
	{ (Il2CppRGCTXDataType)3, 4863 },
	{ (Il2CppRGCTXDataType)1, 1830 },
	{ (Il2CppRGCTXDataType)2, 4130 },
	{ (Il2CppRGCTXDataType)3, 7567 },
	{ (Il2CppRGCTXDataType)1, 4130 },
	{ (Il2CppRGCTXDataType)1, 2106 },
	{ (Il2CppRGCTXDataType)2, 4208 },
	{ (Il2CppRGCTXDataType)2, 4130 },
	{ (Il2CppRGCTXDataType)3, 7572 },
	{ (Il2CppRGCTXDataType)3, 7570 },
	{ (Il2CppRGCTXDataType)3, 7569 },
	{ (Il2CppRGCTXDataType)2, 474 },
	{ (Il2CppRGCTXDataType)3, 4876 },
	{ (Il2CppRGCTXDataType)2, 634 },
};
extern const CustomAttributesCacheGenerator g_System_Core_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_System_Core_CodeGenModule;
const Il2CppCodeGenModule g_System_Core_CodeGenModule = 
{
	"System.Core.dll",
	155,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	54,
	s_rgctxIndices,
	252,
	s_rgctxValues,
	NULL,
	g_System_Core_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
